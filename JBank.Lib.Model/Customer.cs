using System;
using System.Collections.Generic;
using System.Text;

namespace JBank.Lib.Model
{
    public class Customer
    {
        public Customer()
        {
            Accounts = new HashSet<Account>();
            Transacts = new HashSet<Transact>();
        }
        public string CustomerId { get; set; } = Guid.NewGuid().ToString();


        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public ICollection<Account> Accounts { get; set; }
        public ICollection<Transact> Transacts { get; set; }
    }
}
