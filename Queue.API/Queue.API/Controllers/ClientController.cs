using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
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
        public IActionResult Get(ulong id)
        {
            var entity = _clientService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Client client)
        {
            var entity = _clientService.Create(client);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Client client, ulong id)
        {
            var entity = _clientService.Update(client, id);
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
