using MicroServiceEduCustomer.Domain.Model;
using MicroServiceEduCustomer.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Persistence.Mappers
{
    public interface ICustomerEfMapper
    {
        public ICustomer Map(CustomerEf customerEf);
        public CustomerEf Create(ICustomer customer);
    }
}
