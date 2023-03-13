using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Application.Requests.ServiceRequests;
using Queue.Application.Responses.ServiceResponses;
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
        public async  Task<ActionResult<ServiceResponse>> Get(ulong id)
        {
            var entity = await _serviceService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse>> Post(CreateServiceRequest service)
        {
            var entity = await _serviceService.Create(service);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceResponse>> Put(CreateServiceRequest service, ulong id)
        {
            var entity = await _serviceService.Update(service, id);
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
