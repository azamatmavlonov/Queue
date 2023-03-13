using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Models
{
    public class Schedule : EntityBase
    {
        public Worker Worker { get; set; }
        public int WorkerId { get; set; }
        public DateOnly Day { get; set; }
        public int Hour { get; set; }
        public bool IsWorkingDay { get; set; } = true;
        public bool IsEnable { get; set; } = true;
    }
}
