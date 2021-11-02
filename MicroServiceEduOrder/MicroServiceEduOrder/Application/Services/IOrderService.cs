using MicroServiceEduOrder.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Services
{
    public interface IOrderService
    {
        public OrderDto Get(int orderId);
        public OrderDto Create(OrderDto order);
    }
}
