using AutoMapper;
using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Application.Requests.ServiceRequests;
using Queue.Application.Responses.ServiceResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class ServiceService : BaseService<Service, ServiceRequest, ServiceResponse>, IServiceService
    {
        private readonly IRepository<Service> _repository;
        private readonly IMapper _mapper;

        public ServiceService(IRepository<Service> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<ServiceResponse> Create(ServiceRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Service));

            var createServiceRequest = request as CreateServiceRequest;
            var entity = _mapper.Map<CreateServiceRequest, Service>(createServiceRequest);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<Service, ServiceResponse>(entity);
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException(nameof(Service));

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public async override Task<ServiceResponse> Get(ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Service));

            return _mapper.Map<Service, ServiceResponse>(entity);
        }

        public async override Task<ServiceResponse> Update(ServiceRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Service));

            var updateServiceRequest = request as UpdateServiceRequest;
            var result = _mapper.Map(updateServiceRequest, entity);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<Service, ServiceResponse>(result);
        }
    }
}
