using MicroServiceEduOrder.Domain.Model;
using MicroServiceEduOrder.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Persistence.Mappers
{
    public interface IOrderEfMapper
    {
        public IOrder Map(OrderEf orderEf);
        public OrderEf Create(IOrder order);
    }
}
