using JBank.Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBank.Lib.Core.Interface
{
    public interface IAccountRepository
    {
        Customer CreateTheAccount(string acctType, int initialDeposit, string narate, string password, Customer customer);
        void Deposit(string cusId, string accno, decimal amt, string note, string type);
        string[] Withdraw(string cusId, string accno, decimal amt, string note, string type);
        string[] Transfer(string cusId, string recipient, string recpAccId, string senderNumber, string receiverNumber, decimal amt, string note, string typeFr, string typeTo);
        decimal GetDbBalance(string accno);
    }
}
