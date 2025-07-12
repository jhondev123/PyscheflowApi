using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Users.Login.Dtos
{
    public sealed class LoginRequestDto
    {
            
        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
            
        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [JsonPropertyName("companyId")]
        [Required(ErrorMessage = "CompanyId is required.")]
        public Guid? CompanyId { get; set; }
    }
}
