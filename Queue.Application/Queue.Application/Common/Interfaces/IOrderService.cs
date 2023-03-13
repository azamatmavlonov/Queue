using Queue.Application.Requests.OrderRequests;
using Queue.Application.Responses.OrderResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IOrderService : IBaseService<Order, CreateOrderRequest, OrderResponse>
    {
    }
}
