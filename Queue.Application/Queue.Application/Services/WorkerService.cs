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
    public class WorkerService : BaseService<Worker>, IWorkerService
    {
        private readonly IRepository<Worker> _repository;

        public WorkerService(IRepository<Worker> repository)
        {
            _repository = repository;
        }

        // Create, Delete, Get, Update

        public Worker Create(Worker worker)
        {
            if (worker == null) throw new NullReferenceException();

            _repository.Add(worker);
            _repository.SaveChanges();
            return worker;
        }

        public Worker Get(ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public Worker Update(Worker worker, ulong id)
        {
            var entity = _repository.Find(id);

            if (entity == null) throw new NullReferenceException();

            entity.FirstName = worker.FirstName;
            entity.LastName = worker.LastName;
            entity.Phone = worker.Phone;
            entity.Gender = worker.Gender;
            entity.Birthday = worker.Birthday;
            entity.Login = worker.Login;
            entity.Password = worker.Password;
            entity.Schedule = worker.Schedule;
            entity.Role = worker.Role;
            entity.InstagramAccount = worker.InstagramAccount;
            entity.DateOfEmployment = worker.DateOfEmployment;
            entity.DesmissialDate = worker.DesmissialDate;
            entity.Discharge = worker.Discharge;
            entity.Post = worker.Post;

            _repository.Update(entity);
            _repository.SaveChanges();
            return worker;
        }
    }
}
