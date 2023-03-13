using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
using Queue.Application.Requests.ScheduleRequests;
using Queue.Application.Responses.ScheduleResponses;
using Queue.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace Queue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleContoller : ControllerBase
    {
        private readonly IScheduleService _scheduleService;
        public ScheduleContoller(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleResponse>> Get(ulong id)
        {
            var entity = await _scheduleService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<ScheduleResponse>> Post(CreateScheduleRequest schedule)
        {
            var entity = await _scheduleService.Create(schedule);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ScheduleResponse>> Put(CreateScheduleRequest schedule, ulong id)
        {
            var entity = await _scheduleService.Update(schedule, id);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(ulong id)
        {
            var entity = _scheduleService.Delete(id);
            return Ok(entity);
        }
    }
}
