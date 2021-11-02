using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroServiceEduCustomer.Persistence.Model;
using Microsoft.EntityFrameworkCore;
namespace MicroServiceEduCustomer.Persistence
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<CustomerEf> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEf>().ToTable("Customer");
        }
    }
}
