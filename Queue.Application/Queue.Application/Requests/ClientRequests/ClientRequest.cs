﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Requests.ClientRequests
{
    public abstract class ClientRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
    }
}
