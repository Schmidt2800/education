using MicroServiceEduOrder.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();
            //look for any customers
            if (context.Orders.Any())
            {
                return; //db has been seeded
            }

            var orders = new OrderEf[]
            {
                new OrderEf{
                    CustomerId = 1,
                    OrderNo = "SO001"
                },
                new OrderEf{
                    CustomerId = 1,
                    OrderNo = "SO002"
                },
            };

            foreach (OrderEf order in orders)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
