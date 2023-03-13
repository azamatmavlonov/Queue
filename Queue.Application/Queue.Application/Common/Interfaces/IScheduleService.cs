using Queue.Application.Requests.ScheduleRequests;
using Queue.Application.Responses.ScheduleResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IScheduleService : IBaseService<Schedule, CreateScheduleRequest, ScheduleResponse>
    {
    }
}
