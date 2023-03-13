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
    public class ClientService : BaseService<Client, ClientRequest, ClientResponse>, IClientService
    {
        private readonly IRepository<Client> _repository;
        private readonly IMapper _mapper;
        
        public ClientService(IRepository<Client> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<ClientResponse> Create(ClientRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Client));

            var createClientRequest = request as CreateClientRequest;
            var entity = _mapper.Map<CreateClientRequest, Client>(createClientRequest);

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

        public async override Task<ClientResponse> Update(ClientRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);
            if (entity == null) throw new NullReferenceException(nameof(Client));

            var updateClientRequest = request as UpdateClientRequest;
            var result = _mapper.Map(updateClientRequest, entity);
            
            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Client, ClientResponse>(result);
        }
    }
}
