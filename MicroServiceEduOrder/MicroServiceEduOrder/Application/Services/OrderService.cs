using MicroServiceEduOrder.Application.Mappers;
using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IOrderDtoMapper _OrderDtoMapper;
        public OrderService(IOrderRepository orderRepository, IOrderDtoMapper orderDtoMapper)
        {
            _OrderRepository = orderRepository;
            _OrderDtoMapper = orderDtoMapper;
        }
        public OrderDto Create(OrderDto orderDto)
        {
            var order = _OrderDtoMapper.Create(orderDto);
            var createdOrder = _OrderRepository.CreateOrder(order);
            GenerateDocument(createdOrder);
            return _OrderDtoMapper.Map(createdOrder);
        }

        public OrderDto Get(int orderId)
        {
            var order = _OrderRepository.GetOrder(orderId);
            return _OrderDtoMapper.Map(order);
        }
        private void GenerateDocument(IOrder order)
        {

        }
    }
}
