﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue.Domain.Models;

namespace Queue.Application.Requests.WorkerRequests
{
    public abstract class WorkerRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public Schedule Schedule { get; set; }
        public ulong ScheduleId { get; set; }
        public string? InstagramAccount { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DesmissialDate { get; set; }
        public int Discharge { get; set; } = 1;
        public int Post { get; set; } = default;
    }
}
