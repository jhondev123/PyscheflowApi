﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Patient: BaseEntity
    {
        public User? User { get; set; }
        public string? UserId { get; set; } = null;
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Session> Sessions { get; set; }

        public Patient()
        {
        }

        public Patient(string? userId, Guid companyId)
        {
            UserId = userId;
            CompanyId = companyId;
        }
    }
}
