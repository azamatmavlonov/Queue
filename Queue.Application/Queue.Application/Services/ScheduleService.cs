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
    public class ScheduleService : BaseService<Schedule>, IScheduleService
    {
        private readonly IRepository<Schedule> _repository;

        public ScheduleService(IRepository<Schedule> repository)
        {
            _repository = repository;
        }

        public override Schedule Create(Schedule entity)
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

        public override Schedule Get(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public override Schedule Update(Schedule schedule, ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            entity.WorkerId = schedule.WorkerId;
            entity.Day = schedule.Day;
            entity.Hour = schedule.Hour;
            entity.IsWorkingDay = schedule.IsWorkingDay;
            entity.IsEnable = schedule.IsEnable;

            _repository.Update(entity);
            _repository.SaveChanges();
            return entity;
        }
    }
}
