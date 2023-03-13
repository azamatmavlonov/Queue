using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Responses.ServiceResponses
{
    public class ServiceResponse : BaseResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AverageExecutionTime { get; set; }
        public double Price { get; set; }
    }
}
