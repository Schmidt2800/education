using MicroServiceEduCustomer.Application.Model;
using MicroServiceEduCustomer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Application.Mappers
{
    public interface ICustomerDtoMapper
    {
        public CustomerDto Map(ICustomer customer);
        public ICustomer Create(CustomerDto customerDto);
    }
}
