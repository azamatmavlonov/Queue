using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Queue.Application.Requests.OrderRequests;

namespace Queue.Application.Validations.OrderValidations
{
    public class CreateOrderValidation : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderValidation()
        {
            
        }
    }
}
