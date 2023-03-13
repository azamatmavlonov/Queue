using Queue.Application.Requests.ClientRequests;
using Queue.Application.Responses.ClientResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IClientService : IBaseService<Client, CreateClientRequest, ClientResponse>
    {
    }
}
