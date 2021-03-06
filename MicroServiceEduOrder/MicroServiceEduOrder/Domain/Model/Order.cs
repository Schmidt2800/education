using System.Collections.Generic;

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
        public decimal TotalAmount { get; set; }
        public List<int> Products { get; set; }
    }
}
