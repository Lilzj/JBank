using System;
using System.Collections.Generic;
using System.Text;
using JBank.Lib.Model;

namespace JBank.Lib.Core.Interface
{
   public interface IAuthenticationRepository
    {
        string[] Register(Customer cust);
        bool Login(string email, string password);
        void Logout();
    }
}
