using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence.Model
{
    public class OrderLineEf
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int OrderID { get; set; }
        public OrderEf Order { get; set; }
    }
}
