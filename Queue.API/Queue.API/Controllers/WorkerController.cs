using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace Queue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;
        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(ulong id)
        {
            var entity = _workerService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Worker worker)
        {
            var entity = _workerService.Create(worker);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Worker worker, ulong id)
        {
            var entity = _workerService.Update(worker, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _workerService.Delete(id);
            return Ok(entity);
        }
    }
}
