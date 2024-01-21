using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Patient
    {
        public string Name { get; set; }
        public string? PrimaryCareProvider { get; set; }
        public HealthCarePlanCode HealthCarePlanCode { get; set; }

        public Patient(string name, HealthCarePlanCode healthCarePlanCode)
        {
            Name = name;
            HealthCarePlanCode = healthCarePlanCode;
        }
    }
}
