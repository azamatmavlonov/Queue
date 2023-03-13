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
    public class WorkerService : BaseService<Worker, CreateWorkerRequest, WorkerResponse>, IWorkerService
    {
        private readonly IRepository<Worker> _repository;
        private readonly IMapper _mapper;

        public WorkerService(IRepository<Worker> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Create, Delete, Get, Update

        public async override Task<WorkerResponse> Create(CreateWorkerRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Worker));

            var entity = _mapper.Map<CreateWorkerRequest, Worker>(request);

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

        public async override Task<WorkerResponse> Update(CreateWorkerRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Worker));

            //entity.FirstName = worker.FirstName;
            //entity.LastName = worker.LastName;
            //entity.Phone = worker.Phone;
            //entity.Gender = worker.Gender;
            //entity.Birthday = worker.Birthday;
            //entity.Login = worker.Login;
            //entity.Password = worker.Password;
            //entity.Schedule = worker.Schedule;
            //entity.Role = worker.Role;
            //entity.InstagramAccount = worker.InstagramAccount;
            //entity.DateOfEmployment = worker.DateOfEmployment;
            //entity.DesmissialDate = worker.DesmissialDate;
            //entity.Discharge = worker.Discharge;
            //entity.Post = worker.Post;

            var result = _mapper.Map<CreateWorkerRequest, WorkerResponse>(request);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Worker, WorkerResponse>(entity);
        }
    }
}
