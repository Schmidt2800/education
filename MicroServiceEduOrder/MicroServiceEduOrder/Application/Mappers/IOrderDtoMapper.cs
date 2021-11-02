using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Application.Mappers
{
    public interface IOrderDtoMapper
    {
        public OrderDto Map(IOrder order);
        public IOrder Create(OrderDto orderDto);
    }
}
