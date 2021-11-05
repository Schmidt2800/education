using MicroServiceEduOrder.Application.Model;

namespace MicroServiceEduOrder.Application.Services
{
    public interface IOrderService
    {
        public OrderDto Get(int orderId);
        public OrderDto Create(OrderDto order);
    }
}
