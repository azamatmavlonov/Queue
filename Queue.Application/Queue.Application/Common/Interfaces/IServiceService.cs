using Queue.Application.Requests.ServiceRequests;
using Queue.Application.Responses.ServiceResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IServiceService : IBaseService<Service, CreateServiceRequest, ServiceResponse>
    {
    }
}
