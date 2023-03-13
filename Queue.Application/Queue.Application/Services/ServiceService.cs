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
    public class ServiceService : BaseService<Service>, IServiceService
    {
        private readonly IRepository<Service> _repository;

        public ServiceService(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public override Service Create(Service entity)
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

        public override Service Get(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public override Service Update(Service service, ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            entity.Name = service.Name; 
            entity.Description = service.Description;
            entity.Price = service.Price;

            _repository.Update(entity);
            _repository.SaveChanges();
            return entity;
        }
    }
}
