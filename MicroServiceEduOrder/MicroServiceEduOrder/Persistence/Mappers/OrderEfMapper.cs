using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence.Mappers
{
    public class OrderEfMapper : IOrderEfMapper
    {
        public OrderEf Create(IOrder order)
        {
            return new OrderEf()
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo
            };
        }

        public IOrder Map(OrderEf orderEf)
        {
            return new Order()
            {
                ID = orderEf.ID,
                CustomerId = orderEf.CustomerId,
                OrderNo = orderEf.OrderNo
            };
        }
    }
}
