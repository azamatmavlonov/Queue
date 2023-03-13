using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Application.Requests.OrderRequests;
using Queue.Application.Responses.ClientResponses;
using Queue.Application.Responses.OrderResponses;
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
        public async Task<ActionResult<OrderResponse>> Get(ulong id)
        {
            var entity = await _orderService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<OrderResponse>> Post(CreateOrderRequest order)
        {
            var entity = await _orderService.Create(order);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<OrderResponse>> Put(CreateOrderRequest order, ulong id)
        {
            var entity = await _orderService.Update(order, id);
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
