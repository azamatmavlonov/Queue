using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        private readonly IRepository<Order> _repository;
        public OrderService(IRepository<Order> repository) 
        { 
            _repository = repository;
        }

        public override Order Create(Order entity)
        {
            if (entity == null) throw new NullReferenceException();

            _repository.Add(entity);
            _repository.SaveChanges();
            return entity;
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public override Order Get(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public override Order Update(Order order, ulong id)
        {
            var entity = _repository.Find(id);

            if (order == null) throw new NullReferenceException();

            entity.ScheduleId = order.ScheduleId;
            entity.Services = order.Services;
            entity.ClientId = order.ClientId;
            entity.WorkerId = order.WorkerId;
            entity.StartedAt = order.StartedAt;
            entity.EndedAt = order.EndedAt;
            entity.TotalPrice = order.TotalPrice;
            entity.Status = order.Status;
            entity.Payment = order.Payment;

            _repository.Update(entity);
            _repository.SaveChanges();

            return entity;
        }
    }
}
