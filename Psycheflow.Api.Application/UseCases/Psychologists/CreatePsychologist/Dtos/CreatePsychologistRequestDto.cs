using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist.Dtos
{
    public sealed class CreatePsychologistRequestDto 
    {
        public string DocumentNumber { get; set; }
        public CreatePsychologistRequestDto(string documentNumber)
        {
            DocumentNumber = documentNumber;

        }
    }
}
