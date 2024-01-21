using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
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
