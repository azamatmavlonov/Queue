using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Requests.OrderRequests;
using Queue.Application.Requests.ScheduleRequests;
using Queue.Application.Requests.ServiceRequests;
using Queue.Application.Requests.WorkerRequests;
using Queue.Application.Responses.ClientResponses;
using Queue.Application.Responses.OrderResponses;
using Queue.Application.Responses.ScheduleResponses;
using Queue.Application.Responses.ServiceResponses;
using Queue.Application.Responses.WorkerResponses;
using Queue.Domain.Models;

namespace Queue.Application.Mappers
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Client, ClientResponse>();
            CreateMap<ClientRequest, Client>();

            CreateMap<Order, OrderResponse>();
            CreateMap<OrderRequest, Order>();

            CreateMap<Schedule, ScheduleResponse>();
            CreateMap<ScheduleRequest, Schedule>();

            CreateMap<Service, ServiceResponse>();
            CreateMap<ServiceRequest, Service>();

            CreateMap<Worker, WorkerResponse>();
            CreateMap<WorkerRequest, Worker>();
        }
    }
}
