using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Psycheflow.Api.Application.Services;
using Psycheflow.Api.Application.UseCases.Users.CreateUser;
using Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos;
using Psycheflow.Api.Application.UseCases.Users.Login;
using Psycheflow.Api.Application.UseCases.Users.Login.Dtos;
using Psycheflow.Api.Domain.Entities;
using System.Text.Json;

namespace Psycheflow.Api.Controllers
{
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenService _tokenService;

        public UserController(UserManager<User> userManager,
                              SignInManager<User> signInManager,
                              TokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto requestDto)
        {
            RegisterUseCase useCase = new RegisterUseCase(_userManager);
            RegisterResponseDto responseDto = await useCase.Execute(requestDto,new CancellationToken());

            return StatusCode(responseDto.Status, responseDto);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto requestDto)
        {
            LoginUseCase useCase = new LoginUseCase(_userManager, _signInManager, _tokenService);
            LoginResponseDto responseDto = await useCase.Execute(requestDto,new CancellationToken());

            return StatusCode(responseDto.Status, responseDto);
        }
    }
}
