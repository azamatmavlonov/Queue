using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Application.Requests.WorkerRequests;
using Queue.Application.Responses.WorkerResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class WorkerService : BaseService<Worker, WorkerRequest, WorkerResponse>, IWorkerService
    {
        private readonly IRepository<Worker> _repository;
        private readonly IMapper _mapper;

        public WorkerService(IRepository<Worker> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<WorkerResponse> Create(WorkerRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Worker));

            var createWorkerRequest = request as CreateWorkerRequest;
            var entity = _mapper.Map<CreateWorkerRequest, Worker>(createWorkerRequest);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Worker, WorkerResponse>(entity);
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException(nameof(Worker));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return true;
        }

        public async override Task<WorkerResponse> Get(ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Worker));

            return _mapper.Map<Worker, WorkerResponse>(entity);
        }

        public async override Task<WorkerResponse> Update(WorkerRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Worker));

            var updateWorkerRequest = request as UpdateWorkerRequest;
            var result = _mapper.Map(updateWorkerRequest, entity);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Worker, WorkerResponse>(result);
        }
    }
}
