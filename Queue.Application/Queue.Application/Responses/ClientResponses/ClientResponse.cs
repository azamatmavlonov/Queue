using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Application.Responses.ClientResponses
{
    public class ClientResponse : BaseResponse
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
    }
}
