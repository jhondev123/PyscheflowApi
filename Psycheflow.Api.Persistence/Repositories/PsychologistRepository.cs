using Microsoft.EntityFrameworkCore;
using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces.Interfaces;
using Psycheflow.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Persistence.Repositories
{
    public class PsychologistRepository : BaseRepository<Psychologist>, IPsychologistRepository
    {
        public PsychologistRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Psychologist> GetByDocumentNumber(string documentNumber, CancellationToken cancellationToken)
        {
            return Context.Psychologists.FirstOrDefaultAsync(x => x.LicenseNumber.Value.Equals(documentNumber, StringComparison.Ordinal), cancellationToken);
        }
    }
}
