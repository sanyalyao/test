namespace Homework2.Doctors
{
    class Doctor
    {
        /// <summary>
        /// Метод лечить
        /// </summary>
        /// <param name="name"></param>
        public virtual void Care(string name)
        {
            Console.WriteLine($"У пациента {name} лечащий врач - ???");
        }
    }
}
