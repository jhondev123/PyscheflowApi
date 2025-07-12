using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.Login.Dtos
{
    public class LoginResponseDto : GenericResponseDto
    {

        public LoginResponseDto(string token,int status,string message = "")
        {
            Data = new Dictionary<string, object>() { { "token", token } };
            Status = status;
            Message = message;
        }
    }
}
