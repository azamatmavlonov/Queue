using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace Queue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(ulong id)
        {
            var entity = _serviceService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Service service)
        {
            var entity = _serviceService.Create(service);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Service service, ulong id)
        {
            var entity = _serviceService.Update(service, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _serviceService.Delete(id);
            return Ok(entity);
        }
    }
}
