using MicroServiceEduCustomer.Domain.Model;
using MicroServiceEduCustomer.Domain.Repository;
using MicroServiceEduCustomer.Persistence.Mappers;
using MicroServiceEduCustomer.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Persistence.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _Context;
        private readonly ICustomerEfMapper _CustomerEfMapper;
        public CustomerRepository(CustomerContext context, ICustomerEfMapper customerEfMapper)
        {
            _Context = context;
            _CustomerEfMapper = customerEfMapper;
        }
        public ICustomer CreateCustomer(ICustomer customer)
        {
            var customerEf = _CustomerEfMapper.Create(customer);
            _Context.Add(customerEf);
            _Context.SaveChanges();
            return _CustomerEfMapper.Map(customerEf);
        }

        public ICustomer GetCustomer(int customerId)
        {
            var customerEf = GetCustomerEf(customerId);
            return _CustomerEfMapper.Map(customerEf);
        }

        public IEnumerable<ICustomer> GetCustomers()
        {

            var customersEf = _Context.Customers.ToList();
            List<ICustomer> customers = new List<ICustomer>();
            foreach (CustomerEf e in customersEf)
            {
                customers.Add(_CustomerEfMapper.Map(e));
            }
            return customers;
        }

        private CustomerEf GetCustomerEf(int customerId)
        {
            return _Context.Customers.FirstOrDefault(c => c.ID == customerId);
        }
    }
}
