using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : EntityBase
    {
        TEntity Create(TEntity entity);
        TEntity Get(ulong id);
        TEntity Update(TEntity entity, ulong id);
        bool Delete(ulong id);
    }
}
