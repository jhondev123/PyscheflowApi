using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist.Dtos
{
    public sealed class CreatePsychologistResponseDto 
    {
        public string DocumentNumber { get; set; }
        public CreatePsychologistResponseDto(string message, string status, string documentNumber)
        {
            DocumentNumber = documentNumber;
        }
    }
}
