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
            var order = new Order()
            {
                ID = orderDto.ID,
                CustomerId = orderDto.CustomerId,
                OrderNo = orderDto.OrderNo
            };

            foreach(var productId in orderDto.Products)
            {
                order.Products.Add(productId);
            }

            return order;

        }

        public OrderDto Map(IOrder order)
        {
            var orderDto = new OrderDto()
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo
            };
            foreach(var productId in order.Products)
            {
                orderDto.Products.Add(productId);
            }
            return orderDto;
        }
    }
}
