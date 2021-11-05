using MicroServiceEduOrder.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceEduOrder.Persistence
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }
        public DbSet<OrderEf> Orders { get; set; }
        public DbSet<OrderLineEf> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEf>().ToTable("Order");
            modelBuilder.Entity<OrderLineEf>().ToTable("OrderLine");
            //modelBuilder.Entity<OrderLineEf>().HasOne(ol => ol.Order).WithMany(o => o.OrderLines);
            //modelBuilder.Entity<OrderEf>().Navigation(o => o.OrderLines).UsePropertyAccessMode(PropertyAccessMode.Property);
        }
    }
}
