using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Queue.Application.Requests.ClientRequests;

namespace Queue.Application.Validations.ClientValidations
{
    public class CreateClientRequestValidation : AbstractValidator<CreateClientRequest>
    {
        public CreateClientRequestValidation()
        {
            RuleFor(c => c.Name).NotNull().NotEmpty();
            RuleFor(c => c.Phone).NotNull().NotEmpty().Length(15);
        }
    }
}
