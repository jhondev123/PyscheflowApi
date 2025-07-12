using Psycheflow.Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Interfaces.Interfaces
{
    public interface IUserRepository
    {
        public User? GetUser(string email);
        public User? GetUser(string email,Guid companyId);
    }
}
