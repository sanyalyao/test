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
