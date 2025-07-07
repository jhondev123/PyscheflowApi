using Psycheflow.Api.Domain.Interfaces;
using Psycheflow.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _Context;
        public UnitOfWork(AppDbContext context) 
        {
            _Context = context;            
        }
        public async Task Commit(CancellationToken cancellationToken)
        {
            await _Context.SaveChangesAsync(cancellationToken);
        }
    }
}
