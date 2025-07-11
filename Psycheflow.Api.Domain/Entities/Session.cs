using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Session: BaseEntity
    {
        public string Description { get; set; }
        public string Feedback { get; set; }

        public Guid PsychologistId { get; set; }
        public Psychologist Psychologist { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
    }
}
