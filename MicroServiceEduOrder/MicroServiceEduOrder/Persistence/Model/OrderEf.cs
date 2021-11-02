using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence.Model
{
    public class OrderEf
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
    }
}
