using Microsoft.AspNetCore.Identity;
using Psycheflow.Api.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Psycheflow.Api.Domain.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
