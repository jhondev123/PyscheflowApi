using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class PsychologistHours : BaseEntity
    {
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }

        public Psychologist Psychologist { get; set; }
        public Guid PsychologistId { get; set; }

        public TimeSpan StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public PsychologistHours()
        {
        }

        public PsychologistHours(Guid companyId, Guid psychologistId, TimeSpan startTime, DateTime endTime)
        {
            CompanyId = companyId;
            PsychologistId = psychologistId;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
