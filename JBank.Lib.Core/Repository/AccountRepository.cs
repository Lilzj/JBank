using JBank.Lib.Common;
using JBank.Lib.Core.Interface;
using JBank.Lib.Data;
using JBank.Lib.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace JBank.Lib.Core.Repository
{
   public class AccountRepository : IAccountRepository
    {
        private readonly IAuthenticationRepository authrepo;
        private readonly JBankContext _JBContext;
        public AccountRepository(JBankContext jBContext)
        {
            _JBContext = jBContext;
            authrepo = GlobalConfig.IAuthenticationinstance;
        }

        public Customer CreateTheAccount(string acctType, int initialDeposit, string narate, string _password, Customer _customer)
        {
            var hashes = Utilities.GenerateHash(_password);
            byte[] passwordhash = hashes[0];
            byte[] passwordsalt = hashes[1];

            _customer.PasswordHash = passwordhash;
            _customer.PasswordSalt = passwordsalt;

            string acctno = Utilities.GenerateNumber();

            AuthenticationRepository.CurrentUser = _customer;

            var account = new Account() { AccountNumber = acctno, CustomerId = _customer.CustomerId, Type = acctType, Balance = initialDeposit };

            var tran = new Transact() { AccountId = account.AccountId, CustomerId = _customer.CustomerId, AccountNumber = acctno, Amount = initialDeposit, Note = narate, AccountType = acctType };
            account.Transacts.Add(tran);
            _customer.Accounts.Add(account);

            return _customer;
        }

        public void Deposit(string cusId, string accno, decimal amt, string note, string type)
        {

                var check = _JBContext.Customers.Include(x => x.Accounts).FirstOrDefault(x => x.CustomerId == cusId);

                foreach (var acc in check.Accounts)
                {
                    var tran = new Transact() { AccountId = acc.AccountId, CustomerId = cusId, AccountNumber = accno, Amount = amt, Note = note, AccountType = type };
                _JBContext.Transacts.Add(tran);
                _JBContext.SaveChanges();
                   
                }
        }

        public string[] Transfer(string cusId, string recipient, string recpAccId, string senderNumber, string receiverNumber, decimal amt, string note, string typeFr, string typeTo)
        {
            var res = new string[2];
         
                        var tranFr = new Transact();
                        var check = _JBContext.Customers.Include(x => x.Accounts).FirstOrDefault(x => x.CustomerId == cusId);
                        foreach (var acc in check.Accounts)
                        {
                            tranFr = new Transact() { AccountId = acc.AccountId, CustomerId = cusId, AccountNumber = senderNumber, Amount = -amt, Note = note, AccountType = typeFr };                           
                        }
                        var tranTo = new Transact() { AccountId = recpAccId, CustomerId = recipient, AccountNumber = receiverNumber, Amount = amt, Note = note, AccountType = typeTo };
                        _JBContext.Transacts.AddRange(tranFr, tranTo);
                    
            var bal = GetDbBalance(senderNumber);
            if (bal < amt)
            {
                res[0] = "failed";
                res[1] = "INSUFFICIENT FUNDS: MINIMUM BALANCE EXCCEDED!";
                return res;
            }
            else
            {
                Withdraw(cusId,senderNumber, amt, note, typeFr);
                Deposit(cusId,receiverNumber, amt, note, typeTo);
                res[0] = "success";
            }

            return res;


        }

        public string[] Withdraw(string cusId, string accno, decimal amt, string note, string type)
        {
            var res = new string[2];

                var check = _JBContext.Accounts.Include(x => x.Customer).FirstOrDefault(x => x.CustomerId == cusId && x.Type == type);


                var bal = GetDbBalance(accno);
              
                // Ensure the minimum balance is not exceeded
                if (bal < amt)
                {
                    res[0] = "failed";
                    res[1] = "INSUFFICIENT FUNDS : MINIMUM BALANCE EXCEEDED!";
                    return res;
                }
                else
                {
                    var tran = new Transact() { AccountId = check.AccountId, CustomerId = cusId, AccountNumber = accno, Amount = -amt, Note = note, AccountType = type };
                    _JBContext.Transacts.Add(tran);
                    _JBContext.SaveChanges();
                    res[0] = "success";
                }
            
            return res;

        }

        public decimal GetDbBalance(string accno)
        {
            decimal balance = 0;

                var check = _JBContext.Transacts.Where(x => x.AccountNumber == accno);
                    if (check != null)
                    {
                        foreach (var item in check)
                        {
                            balance += item.Amount;
                        }
                        UserSession.CurrentUserID.Add(check.Select(x => x.CustomerId).FirstOrDefault());
                    }
            return balance;
        }

       
    }
}
