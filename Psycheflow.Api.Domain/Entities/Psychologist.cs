using Psycheflow.Api.Domain.Entities.ValueObjects;
using Psycheflow.Api.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public sealed class Psychologist : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public LicenseNumber LicenseNumber { get; set; }
        public ApproachType Approach { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
    }
}
