using MicroServiceEduOrder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Domain.Repository
{
    public interface IOrderRepository
    {
        public IOrder GetOrder(int orderId);
        public IOrder CreateOrder(IOrder order);
    }
}
