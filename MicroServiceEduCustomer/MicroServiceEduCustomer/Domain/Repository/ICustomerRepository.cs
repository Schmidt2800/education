using MicroServiceEduCustomer.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Domain.Repository
{
    public interface ICustomerRepository
    {
        public ICustomer GetCustomer(int customerId);
        public ICustomer CreateCustomer(ICustomer customer);
    }
}
