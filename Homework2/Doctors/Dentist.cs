namespace Homework2.Doctors
{
    class Dentist : Doctor
    {
        public override void Care(string name)
        {
            Console.WriteLine($"У пациента {name} лечащий врач - дантист");
        }
    }
}
