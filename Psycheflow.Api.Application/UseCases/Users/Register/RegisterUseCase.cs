using Microsoft.AspNetCore.Identity;
using Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos;
using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.CreateUser
{
    public sealed class RegisterUseCase : IUseCase<RegisterRequestDto, RegisterResponseDto>
    {
        private UserManager<User> UserManager {  get; set; }
        public RegisterUseCase(UserManager<User> userManager) 
        {
            UserManager = userManager;
        }
        public async Task<RegisterResponseDto> Execute(RegisterRequestDto requestDto, CancellationToken cancellationToken)
        {
            User user = new User
            {
                Name = requestDto.UserName,
                UserName = requestDto.UserName,
                Email = requestDto.Email,
            };

            IdentityResult result = await UserManager.CreateAsync(user, requestDto.Password);
            if (!result.Succeeded)
            {
                return new RegisterResponseDto(null, (int)HttpStatusCode.BadRequest,$"Erro ao gravar o usuário, {result.Errors.First().Description}");
            }
            return new RegisterResponseDto(user, (int)HttpStatusCode.Created);
        }
    }
}
