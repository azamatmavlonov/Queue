using Queue.Application.Common.Interfaces;
using Queue.Application.Requests;
using Queue.Application.Responses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Services
{
    public abstract class BaseService<TEntity, IRequest, IResponse> : IBaseService<TEntity, IRequest, IResponse>
        where TEntity : EntityBase
        where IRequest : BaseRequest
        where IResponse : BaseResponse
    {
        public virtual Task<IResponse> Create(IRequest request)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IResponse> Get(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<IResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<IResponse> Update(IRequest request, ulong id)
        {
            throw new NotImplementedException();
        }
    }
}
