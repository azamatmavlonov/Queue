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
    public class ClientService : BaseService<Client>, IClientService
    {
        private readonly IRepository<Client> _repository;
        public ClientService(IRepository<Client> repository) 
        { 
            _repository = repository;
        }

        public override Client Create(Client entity)
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

        public override Client Get(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public override Client Update(Client client, ulong id)
        {
            var entity = _repository.Find(id);

            if (client == null) throw new NullReferenceException();

            entity.FirstName = client.FirstName;
            entity.LastName = client.LastName;
            entity.Birthday = client.Birthday;
            entity.Phone = client.Phone;
            entity.Login = client.Login;
            entity.Password = entity.Password;
            entity.Discount = client.Discount;

            _repository.Update(entity);
            _repository.SaveChanges();

            return entity;
        }
    }
}
