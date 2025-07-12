using Psycheflow.Api.Domain.Entities;
using Psycheflow.Api.Domain.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Psycheflow.Api.Application.Services
{
    public class UserService
    {
       private IUserRepository Repository { get; set; }
        public UserService(IUserRepository repository) { Repository = repository; }

        public bool VerifyEmailInUse(string email)
        {
            User? user = Repository.GetUser(email);
            if (user == null)
            {
                return false;
            }
            return true;
        }
    }
}
