using Homework2.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public enum HealthCarePlanCode
    {
        First,
        Second,
        NoMater
    }

    class HealthCarePlan
    {
        public void GetPrimaryCareProvider(Patient patient)
        {
            switch(patient.HealthCarePlanCode)
            {
                    case HealthCarePlanCode.First:
                    {
                        var doctor = new Surgeon();
                        patient.PrimaryCareProvider = doctor.GetType().Name;
                        doctor.Care(patient.Name);
                        break;
                    }
                    case HealthCarePlanCode.Second:
                    {
                        var doctor = new Dentist();
                        patient.PrimaryCareProvider = doctor.GetType().Name;
                        doctor.Care(patient.Name);
                        break;
                    }
                default:
                    {
                        var doctor = new Therapist();
                        patient.PrimaryCareProvider = doctor.GetType().Name;
                        doctor.Care(patient.Name);
                        break;
                    }
            }
        }
    }
}
