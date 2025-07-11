using Microsoft.AspNetCore.Identity;
using Psycheflow.Api.Application.Services;
using Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos;
using Psycheflow.Api.Application.UseCases.Users.Login.Dtos;
using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.Login
{
    public class LoginUseCase : IUseCase<LoginRequestDto, LoginResponseDto>
    {
        private UserManager<User> UserManager { get; set; }
        private SignInManager<User> SignInManager { get; set; }
        private TokenService TokenService { get; set; }
        public LoginUseCase(UserManager<User> userManager, SignInManager<User> signInManager, TokenService tokenService)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            TokenService = tokenService;
        }
        public async Task<LoginResponseDto> Execute(LoginRequestDto requestDto, CancellationToken cancellationToken)
        {
            User? user = await UserManager.FindByEmailAsync(requestDto.Email);
            if (user == null)
            {
                return new LoginResponseDto(string.Empty,(int)HttpStatusCode.Unauthorized,"Email ou senha não inválidos");
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await SignInManager.CheckPasswordSignInAsync(user, requestDto.Password, false);
            if (result.Succeeded == false)
            {
                return new LoginResponseDto(string.Empty, (int)HttpStatusCode.Unauthorized, "Email ou senha não inválidos");
            }

            string token = TokenService.GenerateToken(user);
            return new LoginResponseDto(token, (int)HttpStatusCode.OK, string.Empty);
        }
    }
}
