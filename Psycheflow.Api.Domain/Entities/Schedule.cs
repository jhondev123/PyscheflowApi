using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Schedule:BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public Guid PsychologistId { get; set; }
        public Psychologist Psychologist { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public virtual Session Session { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
    }
}
