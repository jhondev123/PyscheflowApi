using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Interfaces
{
    public abstract class GenericResponseDto
    {
        public string Message { get; set; } = string.Empty;
        public int Status { get; set; }
        public Dictionary<string,object>? Data { get; set; }
    }
}
