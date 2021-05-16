using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JBank.Lib.Model
{
   
    public class Transact
    {
       

        public string TransactId { get; set; } = Guid.NewGuid().ToString();
        public string CustomerId { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public Customer Customer { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string AccountType { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;

    }
}
