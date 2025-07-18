﻿using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos
{
    public sealed class RegisterResponseDto : GenericResponseDto
    {       
        public RegisterResponseDto(User? user, int status,string message = "")
        {
            Data = new Dictionary<string, object> { { "user" , user} };
            Status = status;
            Message = message;
        }

    }
}
