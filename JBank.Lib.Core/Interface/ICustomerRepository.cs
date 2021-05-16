using System;
using System.Collections.Generic;
using System.Text;
using JBank.Lib.Model;

namespace JBank.Lib.Core.Interface
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer cust);
        void GetStatements();
    }
}
