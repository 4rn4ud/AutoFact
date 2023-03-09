using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace AutoFact
{

    public class MyContext_old : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }
        //public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mydatabase.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
           // modelBuilder.Entity<Invoice>().ToTable("Invoices");
           // modelBuilder.Entity<InvoiceItem>().ToTable("InvoiceItems");
        }
    }

}
