using Microsoft.AspNetCore.Identity;
using Psycheflow.Api.Application.Services;
using Psycheflow.Api.Application.Shared.Exceptions.User;
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
        private UserService UserService { get; set; }
        public RegisterUseCase(UserManager<User> userManager,UserService userService) 
        {
            UserManager = userManager;
            UserService = userService;
        }
        public async Task<RegisterResponseDto> Execute(RegisterRequestDto requestDto, CancellationToken cancellationToken)
        {
            try
            {
                User user = new User
                {
                    Name = requestDto.UserName,
                    UserName = requestDto.UserName,
                    Email = requestDto.Email,
                    CompanyId = (Guid)requestDto.CompanyId,
                };
                
                if(UserService.VerifyEmailInUse(requestDto.Email))
                {
                    throw new RegisterException("Email ou senha inválidos");
                }

                IdentityResult result = await UserManager.CreateAsync(user, requestDto.Password);
                if (!result.Succeeded)
                {
                    throw new RegisterException(result.Errors.First().Description);
                }
                return new RegisterResponseDto(user, (int)HttpStatusCode.Created);
            }
            catch (Exception ex) 
            {
                return new RegisterResponseDto(null, (int)HttpStatusCode.BadRequest, $"Erro ao gravar o usuário, {ex.Message}");
            }
        }
    }
}
