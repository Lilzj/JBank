using JBank.Lib.Core.Interface;
using JBank.Lib.Core.Repository;
using JBank.Lib.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JBank.Lib.Core
{
    public class GlobalConfig
    {
        public static IAccountRepository IAccountinstance { get; private set; }
        
        public static ICustomerRepository ICustomerinstance { get; private set; }
        public static IAuthenticationRepository IAuthenticationinstance { get; private set; }
        private static JBankContext _JBContext { get; set; }
       

        public static void AddIinstance()
        {
            _JBContext = new JBankContext();
            AccountRepository op = new AccountRepository(_JBContext);
            CustomerRepository oc = new CustomerRepository();
            AuthenticationRepository ar = new AuthenticationRepository(_JBContext);
          
            IAccountinstance = op;
            ICustomerinstance = oc;
            IAuthenticationinstance = ar;
        }

        public static void RemoveIinstance()
        {
            IAccountinstance = null;
            ICustomerinstance = null;
            IAuthenticationinstance = null;
        }
    }
}
