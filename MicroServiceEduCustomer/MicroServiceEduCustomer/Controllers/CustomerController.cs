using MicroServiceEduCustomer.Application.Model;
using MicroServiceEduCustomer.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduCustomer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _CustomerService;

        public CustomerController(ICustomerService customerService)
        {
            _CustomerService = customerService;
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<CustomerDto> Get(int id)
        {
            var customer = _CustomerService.Get(id);

            if (customer == null)
                return NotFound();

            return customer;
        }
        // POST action
        [HttpPost]
        public IActionResult Create(CustomerDto customer)
        {
            var createdCustomer = _CustomerService.Create(customer);
            return CreatedAtAction(nameof(Create), new { id = createdCustomer.ID }, createdCustomer);
        }
    }
}
