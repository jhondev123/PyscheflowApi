﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psycheflow.Api.Domain.Entities
{
    public class Configuration : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public Configuration()
        {
        }

        public Configuration(string key, string value, string description)
        {
            Key = key;
            Value = value;
            Description = description;
        }
    }
}
