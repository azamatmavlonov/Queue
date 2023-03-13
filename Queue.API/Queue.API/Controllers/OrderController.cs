using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace Queue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(ulong id)
        {
            var entity = _orderService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Order order)
        {
            var entity = _orderService.Create(order);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Order order, ulong id)
        {
            var entity = _orderService.Update(order, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _orderService.Delete(id);
            return Ok(entity);
        }
    }
}
