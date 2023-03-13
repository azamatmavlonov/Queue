using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Domain.Models
{
    public class Service : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
