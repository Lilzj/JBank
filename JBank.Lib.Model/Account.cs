using System;
using System.Collections.Generic;

namespace JBank.Lib.Model
{
    public class Account
    {
        public Account()
        {
            Transacts = new HashSet<Transact>();


        }
        public string AccountId { get; set; } = Guid.NewGuid().ToString();
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public virtual string Type { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public ICollection<Transact> Transacts { get; set; }
    }
}
