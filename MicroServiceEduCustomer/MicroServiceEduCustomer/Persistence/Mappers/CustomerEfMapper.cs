using MicroServiceEduCustomer.Domain.Model;
using MicroServiceEduCustomer.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Persistence.Mappers
{
    public class CustomerEfMapper : ICustomerEfMapper
    {
        public ICustomer Map(CustomerEf customerEf)
        {
            return new Customer
            {
                ID = customerEf.ID,
                FirstName = customerEf.FirstName,
                LastName = customerEf.LastName,
                Street = customerEf.Street,
                PostCode = customerEf.PostCode,
                City = customerEf.City,
                Country = customerEf.Country,
                Phone = customerEf.Phone,
                Email = customerEf.Email,
            };
        }
        public CustomerEf Create(ICustomer customer)
        {
            return new CustomerEf
            {
                ID = customer.ID,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Street = customer.Street,
                PostCode = customer.PostCode,
                City = customer.City,
                Country = customer.Country,
                Phone = customer.Phone,
                Email = customer.Email,
            };
        }
    }
}
