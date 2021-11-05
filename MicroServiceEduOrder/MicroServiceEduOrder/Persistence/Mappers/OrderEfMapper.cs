using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Persistence.Model;

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
