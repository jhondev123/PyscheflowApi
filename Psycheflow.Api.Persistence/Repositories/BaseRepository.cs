using Microsoft.EntityFrameworkCore;
using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces;
using Psycheflow.Api.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;
        public BaseRepository(AppDbContext context) 
        {
            Context = context;
        }
        public T Create(T entity)
        {
            entity.CreatedAt = DateTimeOffset.UtcNow;
            Context.Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entity.DeletedAt = DateTimeOffset.UtcNow;
            Context.Remove(entity);
        }

        public async Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<List<T>> GetAll(Guid id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().ToListAsync(cancellationToken);

        }

        public T Update(T entity)
        {
            entity.UpdatedAt = DateTimeOffset.UtcNow;
            Context.Update(entity);
            return entity;
        }
    }
}
