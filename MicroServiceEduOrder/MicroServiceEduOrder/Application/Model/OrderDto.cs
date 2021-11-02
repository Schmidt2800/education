using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Model
{
    public class OrderDto
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
    }
}
