using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue.Domain.Abstract;

namespace Queue.Domain.Models
{
    public class Client : Person
    {
        public int Discount { get; set; } = 0;
    }
}
