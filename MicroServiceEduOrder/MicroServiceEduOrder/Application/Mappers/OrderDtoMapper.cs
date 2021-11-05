using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;

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
                OrderNo = orderDto.OrderNo,
                Products = orderDto.Products,
                TotalAmount = orderDto.TotalAmount
               
            };

            return order;

        }

        public OrderDto Map(IOrder order)
        {
            var orderDto = new OrderDto()
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo,
                Products = order.Products,
                TotalAmount = order.TotalAmount
            };
    
            return orderDto;
        }
    }
}
