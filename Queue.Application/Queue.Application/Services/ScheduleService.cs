using AutoMapper;
using Queue.Application.Common.Interfaces;
using Queue.Application.Common.Interfaces.Repositories;
using Queue.Application.Requests.ScheduleRequests;
using Queue.Application.Responses.ScheduleResponses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public class ScheduleService : BaseService<Schedule, ScheduleRequest, ScheduleResponse>, IScheduleService
    {
        private readonly IRepository<Schedule> _repository;
        private readonly IMapper _mapper;

        public ScheduleService(IRepository<Schedule> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async override Task<ScheduleResponse> Create(ScheduleRequest request)
        {
            if (request == null) throw new NullReferenceException(nameof(Schedule));

            var createScheduleRequest = request as CreateScheduleRequest;
            var entity = _mapper.Map<CreateScheduleRequest, Schedule>(createScheduleRequest);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Schedule, ScheduleResponse>(entity);
        }

        public override bool Delete(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException(nameof(Schedule));

            _repository.Delete(entity);
            _repository.SaveChanges();
            return true;
        }

        public async override Task<ScheduleResponse> Get(ulong id)
        {
            var entity = await _repository.FindAsync(id);

            if (entity == null) throw new NullReferenceException(nameof(Schedule));

            return _mapper.Map<Schedule, ScheduleResponse>(entity);
        }

        public async override Task<ScheduleResponse> Update(ScheduleRequest request, ulong id)
        {
            var entity = await _repository.FindAsync(id);
            if (entity == null) throw new NullReferenceException(nameof(Schedule));

            var updateScheduleRequest = request as UpdateScheduleRequest;
            var result = _mapper.Map(updateScheduleRequest, entity);

            _repository.Update(entity);
            await _repository.SaveChangesAsync();
            return _mapper.Map<Schedule, ScheduleResponse>(result);
        }
    }
}
