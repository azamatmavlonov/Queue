using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Requests.ServiceRequests;

namespace Queue.Application.Validations.ServiceValidations
{
    public class CreateServiceValidation : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceValidation()
        {
            
        }
    }
}
