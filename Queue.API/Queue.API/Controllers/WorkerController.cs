using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Application.Requests.WorkerRequests;
using Queue.Application.Responses.WorkerResponses;
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
        public async Task<ActionResult<WorkerResponse>> Get(ulong id)
        {
            var entity = await _workerService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<WorkerResponse>> Post(CreateWorkerRequest worker)
        {
            var entity = await _workerService.Create(worker);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WorkerResponse>> Put(CreateWorkerRequest worker, ulong id)
        {
            var entity = await _workerService.Update(worker, id);
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
