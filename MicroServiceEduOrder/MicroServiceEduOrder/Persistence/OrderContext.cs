using MicroServiceEduOrder.Persistence.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }
        public DbSet<OrderEf> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<OrderEf>().ToTable("Order");
            //modelBuilder.Entity<OrderLineEf>().ToTable("OrderLine");
            modelBuilder.Entity<OrderLineEf>()
.HasOne(ol => ol.Order)
.WithMany(o => o.);



            modelBuilder.Entity<OrderEf>()
            .Navigation(o => o.OrdreDetailsEf)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
        }
    }
}
