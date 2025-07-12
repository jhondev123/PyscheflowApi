using Microsoft.AspNetCore.Identity;
using Psycheflow.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id,CancellationToken cancellationToken);
        Task<List<T>> GetAll(Guid id,CancellationToken cancellationToken);
    }
}
