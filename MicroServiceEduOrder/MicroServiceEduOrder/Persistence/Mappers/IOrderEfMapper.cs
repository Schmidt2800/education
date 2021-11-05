using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Persistence.Model;

namespace MicroServiceEduOrder.Persistence.Mappers
{
    public interface IOrderEfMapper
    {
        public IOrder Map(OrderEf orderEf);
        public OrderEf Create(IOrder order);
    }
}
