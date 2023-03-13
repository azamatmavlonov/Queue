using Queue.Application.Common.Interfaces;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class WorkerService : BaseService<Worker>, IWorkerService
    {
    }
}
