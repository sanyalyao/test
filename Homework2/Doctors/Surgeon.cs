namespace Homework2.Doctors
{
    class Surgeon : Doctor
    {
        public override void Care(string name)
        {
            Console.WriteLine($"У пациента {name} лечащий врач - хирург");
        }
    }
}
