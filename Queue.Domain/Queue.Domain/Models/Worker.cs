using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue.Domain.Enums;

namespace Queue.Domain.Models
{
    public class Worker : Person
    {
        public string Role { get; set; }
        public Schedule Schedule { get; set; }
        public ulong ScheduleId { get; set; }
        public string? InstagramAccount { get; set; }
        public DateTime DateOfEmployment { get; set; }  
        public DateTime? DesmissialDate { get; set; }
    }
}
