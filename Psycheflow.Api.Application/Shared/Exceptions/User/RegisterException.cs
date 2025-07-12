using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.Shared.Exceptions.User
{
    public class RegisterException:Exception
    {
        public RegisterException(string message) : base(message) { }
    }
}
