using System.Collections.Generic;

namespace MicroServiceEduOrder.Application.Model
{
    public class OrderDto
    {
        public OrderDto()
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
