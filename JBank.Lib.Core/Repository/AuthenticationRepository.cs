using JBank.Lib.Common;
using JBank.Lib.Core.Interface;
using JBank.Lib.Data;
using JBank.Lib.Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace JBank.Lib.Core.Repository
{
   public class AuthenticationRepository : IAuthenticationRepository
    {
        public static Customer CurrentUser;
        private readonly ICustomerRepository custrepository;
        private readonly JBankContext _JBContext;
        public AuthenticationRepository(JBankContext jBContext)
        {
            custrepository = GlobalConfig.ICustomerinstance;
            _JBContext = jBContext;
        }
        public string[] Register(Customer cust)
        {
            string[] res = new string[2];
            if (EmailExist(cust.Email))
            {
                res[0] = "failed";
                res[1] = "Email Already Exists";
            }
            else
            {
                custrepository.CreateCustomer(cust);
                res[0] = "success";
            }
            return res;

        }

        public bool Login(string email, string password)
        {
            if (!IsValidDBCred(email, password))
            {
                return false;
            }
            return true;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        private bool IsValidDBCred(string email, string password)
        {
            try
            {
                bool passwordMatch = false;
                    var check = _JBContext.Customers.FirstOrDefault(x => x.Email == email);

                    if (check != null)
                    {
                        var hash = check.PasswordHash;
                        byte[] salt = check.PasswordSalt;
                    

                            if (Utilities.CompareHash(salt, hash, password))
                            {
                                passwordMatch = true;
                            }                      
                    }
                return passwordMatch;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal bool EmailExist(string email)
        {
                var check = _JBContext.Customers.Any(x => x.Email == email);
                   
                   return check; 
        }
    }
}
