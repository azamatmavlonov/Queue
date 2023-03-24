﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Requests.ServiceRequests
{
    public abstract class ServiceRequest : BaseRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AverageExecutionTime { get; set; }
        public double Price { get; set; }
    }
}
