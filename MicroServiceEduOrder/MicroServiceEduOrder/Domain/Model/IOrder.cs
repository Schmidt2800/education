using System.Collections.Generic;

namespace MicroServiceEduOrder.Domain.Model
{
    public interface IOrder
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
        public List<int> Products { get; set; }
    }
}
