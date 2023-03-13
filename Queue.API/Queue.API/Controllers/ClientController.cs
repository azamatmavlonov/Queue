using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Responses.ClientResponses;
using Queue.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace Queue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientResponse>> Get(ulong id)
        {
            var entity = await _clientService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<ClientResponse>> Post(CreateClientRequest client)
        {
            var entity = await _clientService.Create(client);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ClientResponse>> Put(CreateClientRequest client, ulong id)
        {
            var entity = await _clientService.Update(client, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _clientService.Delete(id);
            return Ok(entity);
        }
    }
}
