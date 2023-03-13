using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Queue.Domain.Models
{
    public abstract class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
