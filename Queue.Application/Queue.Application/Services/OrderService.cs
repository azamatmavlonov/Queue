using AutoMapper;
using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Application.Requests.OrderRequests;
using Queue.Application.Responses.OrderResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class OrderService : BaseService<Order, CreateOrderRequest, OrderResponse>, IOrderService
    {
        private readonly IRepository<Order> _repository;
        private readonly IMapper _mapper;
        public OrderService(IRepository<Order> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<OrderResponse> Create(CreateOrderRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Order));

            var entity = _mapper.Map<CreateOrderRequest, Order>(request);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<Order, OrderResponse>(entity);
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException(nameof(Order));

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public async override Task<OrderResponse> Get(ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Order));

            return _mapper.Map<Order, OrderResponse>(entity);
        }

        public async override Task<OrderResponse> Update(CreateOrderRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Order));

            //entity.Services = order.Services;
            //entity.ClientId = order.ClientId;
            //entity.WorkerId = order.WorkerId;
            //entity.StartedAt = order.StartedAt;
            //entity.EndedAt = order.EndedAt;
            //entity.TotalPrice = order.TotalPrice;
            //entity.Status = order.Status;
            //entity.Payment = order.Payment;

            var result = _mapper.Map<CreateOrderRequest, OrderResponse>(request);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return result;
        }
    }
}
