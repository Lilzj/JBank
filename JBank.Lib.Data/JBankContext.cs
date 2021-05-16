using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JBank.Lib.Model;

namespace JBank.Lib.Data
{
    public class JBankContext : DbContext
    {
       public JBankContext()
        {

        }
        public static string _conString = @"Data Source = C:\Users\hp\source\repos\JBank\JBank.Lib.Data\JBankDb.db";

       
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transact> Transacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_conString);
        }
    }
}
