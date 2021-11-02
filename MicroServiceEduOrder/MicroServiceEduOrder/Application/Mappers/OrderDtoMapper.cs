using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Mappers
{
    public class OrderDtoMapper : IOrderDtoMapper
    {
        public IOrder Create(OrderDto orderDto)
        {
            return new Order()
            {
                ID = orderDto.ID,
                CustomerId = orderDto.CustomerId,
                OrderNo = orderDto.OrderNo
            };
        }

        public OrderDto Map(IOrder order)
        {
            return new OrderDto()
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo
            };
        }
    }
}
