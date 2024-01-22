namespace Homework2.Doctors
{
    class Therapist : Doctor
    {
        public override void Care(string name)
        {
            Console.WriteLine($"У пациента {name} лечащий врач - терапевт");
        }
    }
}
