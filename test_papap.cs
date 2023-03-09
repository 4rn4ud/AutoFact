/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;



namespace AutoFact
{

    public class MyContext : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }
        //public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public string DbPath { get; }

        public MyContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "mydatabase.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }

}
*/