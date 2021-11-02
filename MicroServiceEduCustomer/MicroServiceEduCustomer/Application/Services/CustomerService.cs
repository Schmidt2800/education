using MicroServiceEduCustomer.Application.Mappers;
using MicroServiceEduCustomer.Application.Model;
using MicroServiceEduCustomer.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        private readonly ICustomerDtoMapper _CustomerDtoMapper;
        public CustomerService(ICustomerRepository customerRepository, ICustomerDtoMapper customerDtoMapper)
        {
            _CustomerRepository = customerRepository;
            _CustomerDtoMapper = customerDtoMapper;
        }
        public CustomerDto Create(CustomerDto customerDto)
        {
            var customer = _CustomerDtoMapper.Create(customerDto);


            var createdCustomer = _CustomerRepository.CreateCustomer(customer);

            return _CustomerDtoMapper.Map(createdCustomer);
        }

        public CustomerDto Get(int customerId)
        {
            var customer = _CustomerRepository.GetCustomer(customerId);
            return _CustomerDtoMapper.Map(customer);
        }
    }
}
