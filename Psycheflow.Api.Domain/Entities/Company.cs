using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Company:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Session> Sessions { get; set; }

        public Company()
        {
        }

        public Company(string name)
        {
            Name = name;
        }
    }
}
