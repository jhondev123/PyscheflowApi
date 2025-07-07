using AutoMapper;
using Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist.Dtos;
using Psycheflow.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist
{
    public class CreatePsychologistMapper:Profile
    {
        public CreatePsychologistMapper() 
        {
            CreateMap<CreatePsychologistRequestDto, Psychologist>();
            CreateMap<Psychologist, CreatePsychologistResponseDto>();
        }
    }
}
