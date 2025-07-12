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
        public string UserId { get; set; }
        public User User { get; set; }
        public LicenseNumber LicenseNumber { get; set; }
        public ApproachType Approach { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public ICollection<Schedule> Schedules {  get; set; }
        public ICollection<Session> Sessions { get; set; }
        public ICollection<PsychologistHours> PsychologistHours { get; set; }

        public Psychologist()
        {
        }

        public Psychologist(string userId, LicenseNumber licenseNumber, ApproachType approach, Guid companyId)
        {
            UserId = userId;
            LicenseNumber = licenseNumber;
            Approach = approach;
            CompanyId = companyId;
        }
    }
}
