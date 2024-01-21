using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
