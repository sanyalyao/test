using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
