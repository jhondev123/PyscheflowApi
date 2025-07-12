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
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext Context;
        public UserRepository(AppDbContext context)
        {
            Context = context;
        }

        public User? GetUser(string email)
        {
            return Context.Users.FirstOrDefault(x => x.Email == email);
        }
        public User? GetUser(string email, Guid companyId)
        {
            return Context.Users.FirstOrDefault(x => x.Email == email && x.CompanyId == companyId);
        }
    }
}
