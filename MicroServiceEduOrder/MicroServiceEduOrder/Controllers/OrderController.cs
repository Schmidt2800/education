using MicroServiceEduOrder.Application.Model;
using MicroServiceEduOrder.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduOrder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService orderService)
        {
            _OrderService = orderService;
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<OrderDto> Get(int id)
        {
            var order = _OrderService.Get(id);

            if (order == null)
                return NotFound();

            return order;
        }
        // POST action
        [HttpPost]
        public IActionResult Create(OrderDto order)
        {
            var createdOrder = _OrderService.Create(order);
            return CreatedAtAction(nameof(Create), new { id = createdOrder.ID }, createdOrder);
        }
    }
}
