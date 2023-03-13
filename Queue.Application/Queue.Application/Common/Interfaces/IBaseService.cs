using Queue.Application.Requests;
using Queue.Application.Responses;
using Queue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Common.Interfaces
{
    public interface IBaseService<TEntity, IRequest, IResponse> 
        where TEntity : EntityBase
        where IRequest : BaseRequest
        where IResponse : BaseResponse
    {
        Task<IResponse> Get(ulong id);
        Task<IEnumerable<IResponse>> GetAll();
        Task<IResponse> Create(IRequest request);
        Task<IResponse> Update(IRequest request, ulong id);
        bool Delete(ulong id);
    }
}
