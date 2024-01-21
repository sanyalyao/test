using System;

namespace Homework2
{
    class Homework2
    {
        static void Main()
        {
            var patient1 = new Patient("Igor", HealthCarePlanCode.First);
            var patient2 = new Patient("Masha", HealthCarePlanCode.Second);
            var patient3 = new Patient("Anton", HealthCarePlanCode.NoMater);
            var healthCarePlan = new HealthCarePlan();
            healthCarePlan.GetPrimaryCareProvider(patient1);
            healthCarePlan.GetPrimaryCareProvider(patient2);
            healthCarePlan.GetPrimaryCareProvider(patient3);
        }
    }
}