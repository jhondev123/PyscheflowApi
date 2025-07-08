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
        public string Token { get; set; }
        public User User { get; set; }
    }
}
