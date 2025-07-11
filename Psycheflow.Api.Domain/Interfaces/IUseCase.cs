﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Interfaces
{
    public interface IUseCase<RequestDto, T> where T : GenericResponseDto
    {
        Task<T> Execute(RequestDto requestDto, CancellationToken cancellationToken);
    }
}
