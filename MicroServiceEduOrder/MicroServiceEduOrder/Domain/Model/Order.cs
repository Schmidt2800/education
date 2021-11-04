using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Domain.Model
{
    public class Order : IOrder
    {
        public Order()
        {
            Products = new List<int>();
        }
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
        public List<int> Products { get; set; }
    }
}
