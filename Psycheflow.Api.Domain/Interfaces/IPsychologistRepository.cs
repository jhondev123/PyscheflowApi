using Psycheflow.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Interfaces
{
    public interface IPsychologistRepository : IBaseRepository<Psychologist>
    {
        Task<Psychologist> GetByDocumentNumber(string documentNumber);
    }
}
