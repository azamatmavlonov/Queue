using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Queue.Application.Requests.ClientRequests;
using Queue.Application.Requests.ScheduleRequests;

namespace Queue.Application.Validations.ScheduleValidations
{
    public class CreateScheduleValidation : AbstractValidator<CreateScheduleRequest>
    {
        public CreateScheduleValidation()
        {
            
        }
    }
}
