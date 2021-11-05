using MicroServiceEduOrder.Persistence.Model;
using System.Linq;

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
            //var orderLines = new OrderLineEf[]
            //{
            //    new OrderLineEf{
            //        Order = orders[0],
            //        OrderID = orders[0].ID,
            //        Price = 10.25M
            //    },
            //    new OrderLineEf{
            //        Order = orders[0],
            //        OrderID = orders[0].ID,
            //        Price = 10.25M
            //    }
            //};

            //foreach (OrderLineEf line in orderLines)
            //{
            //    context.OrderLines.Add(line);
            //}
            //context.SaveChanges();
        }
    }
}
