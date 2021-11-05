using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;

namespace MicroServiceEduOrder.Application.Mappers
{
    public interface IOrderDtoMapper
    {
        public OrderDto Map(IOrder order);
        public IOrder Create(OrderDto orderDto);
    }
}
