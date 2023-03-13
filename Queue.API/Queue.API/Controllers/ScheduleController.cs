using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using Queue.Application.Common.Interfaces;
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
        public IActionResult Get(ulong id)
        {
            var entity = _scheduleService.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(Schedule schedule)
        {
            var entity = _scheduleService.Create(schedule);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Schedule schedule, ulong id)
        {
            var entity = _scheduleService.Update(schedule, id);
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
