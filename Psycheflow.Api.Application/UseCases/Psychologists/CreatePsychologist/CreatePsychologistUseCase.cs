using AutoMapper;
using Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist.Dtos;
using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Application.UseCases.Psychologists.CreatePsychologist
{
    public sealed class CreatePsychologistUseCase : IUseCase<CreatePsychologistRequestDto, CreatePsychologistResponseDto>
    {
        private readonly IMapper _mapper;
        private readonly IPsychologistRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePsychologistUseCase(IMapper mapper, IPsychologistRepository repository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CreatePsychologistResponseDto> Execute(CreatePsychologistRequestDto requestDto,CancellationToken cancellationToken)
        {
            Psychologist psychologist = _mapper.Map<Psychologist>(requestDto);

            _repository.Create(psychologist);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreatePsychologistResponseDto>(psychologist);
        }

    }
}
