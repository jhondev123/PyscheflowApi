using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.Login.Dtos
{
    public sealed class LoginRequestDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
