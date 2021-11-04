using MicroServiceEduCustomer.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Application.Services
{
    public interface ICustomerService
    {
        public CustomerDto Get(int customerId);
        public IEnumerable<CustomerDto> GetAll();
        public CustomerDto Create(CustomerDto customerDto);
    }
}
