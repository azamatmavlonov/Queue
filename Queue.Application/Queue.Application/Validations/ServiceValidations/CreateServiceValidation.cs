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
            RuleFor(s => s.Name).NotEmpty().NotNull();
            RuleFor(s => s.Price).GreaterThan(0);
            RuleFor(s => s.AverageExecutionTime).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(s => s.Description).MinimumLength(10).MaximumLength(300);
        }
    }
}
