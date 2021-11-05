using MicroServiceEduOrder.Domain.Model;

namespace MicroServiceEduOrder.Domain.Repository
{
    public interface IOrderRepository
    {
        public IOrder GetOrder(int orderId);
        public IOrder CreateOrder(IOrder order);
    }
}
