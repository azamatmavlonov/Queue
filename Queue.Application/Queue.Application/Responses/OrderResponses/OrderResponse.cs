using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue.Domain.Models;

namespace Queue.Application.Responses.OrderResponses
{
    public class OrderResponse : BaseResponse
    {
        public IEnumerable<Service> Services { get; set; }
        public Order Client { get; set; }
        public ulong ClientId { get; set; }
        public Worker Worker { get; set; }
        public ulong WorkerId { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }
        public string Payment { get; set; }
    }
}
