using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Requests.WorkerRequests;

namespace Queue.Application.Validations.WorkerValidations
{
    public class CreateWorkerValidation : AbstractValidator<CreateWorkerRequest>
    {
        public CreateWorkerValidation()
        {
            
        }
    }
}
