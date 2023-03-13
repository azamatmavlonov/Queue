using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Responses.ClientResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class ClientService : BaseService<Client, CreateClientRequest, ClientResponse>, IClientService
    {
        private readonly IRepository<Client> _repository;
        private readonly IMapper _mapper;
        
        public ClientService(IRepository<Client> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<ClientResponse> Create(CreateClientRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Client));

            var entity = _mapper.Map<CreateClientRequest, Client>(request);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Client, ClientResponse>(entity);
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException(nameof(Client));

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public async override Task<ClientResponse> Get(ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Client));

            return _mapper.Map<Client, ClientResponse>(entity);
        }

        public async override Task<ClientResponse> Update(CreateClientRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Client));

            //entity.FirstName = client.FirstName;
            //entity.LastName = client.LastName;
            //entity.Birthday = client.Birthday;
            //entity.Phone = client.Phone;
            //entity.Login = client.Login;
            //entity.Password = entity.Password;
            //entity.Discount = client.Discount;

            var result = _mapper.Map<CreateClientRequest, ClientResponse>(request);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return result;
        }
    }
}
