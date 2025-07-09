using Psycheflow.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos
{
    public sealed class RegisterResponseDto
    {
        public User User { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }

        public RegisterResponseDto(User user, int status)
        {
            User = user;
            Status = status;
        }

        public RegisterResponseDto(int status, string message)
        {
            Status = status;
            Message = message;
        }
    }
}
