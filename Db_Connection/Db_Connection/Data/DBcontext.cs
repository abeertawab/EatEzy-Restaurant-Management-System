using DBconnection.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Db_Connection.Data
{
    internal class DBcontext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace the connection string with your actual SQL Server connection string
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-O4SPKSH6\\SQLEXPRESS;Initial Catalog=Task2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //LAPTOP-O4SPKSH6\SQLEXPRESS
        }
    }
}
