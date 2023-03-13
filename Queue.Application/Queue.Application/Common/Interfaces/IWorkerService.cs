using Queue.Application.Requests.WorkerRequests;
using Queue.Application.Responses.WorkerResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IWorkerService : IBaseService<Worker, CreateWorkerRequest, WorkerResponse>
    {
    }
}
