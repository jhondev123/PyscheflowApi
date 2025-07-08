using Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos;
using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.CreateUser
{
    public sealed class CreateUserUseCase : IUseCase<RegisterRequestDto, RegisterResponseDto>
    {
        public Task<RegisterResponseDto> Execute(RegisterRequestDto requestDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
