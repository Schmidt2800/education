using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Domain.Model
{
    public interface IOrder
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
    }
}
