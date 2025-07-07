using FluentValidation;
using Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist
{
    public sealed class CreatePsychologistValidator : AbstractValidator<CreatePsychologistRequestDto>
    {
        public CreatePsychologistValidator()
        {
            RuleFor(x => x.DocumentNumber).NotEmpty();
        }
    }
}
