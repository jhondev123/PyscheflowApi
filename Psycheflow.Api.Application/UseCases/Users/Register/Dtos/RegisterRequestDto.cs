using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.CreateUser.Dtos
{
    public sealed class RegisterRequestDto
    {
        [JsonPropertyName("username")]
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [JsonPropertyName("companyId")]
        [Required(ErrorMessage = "CompanyId is required.")]
        public Guid? CompanyId { get; set; }
    }
}
