using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    /// <summary>
    /// равнобедренный
    /// </summary>
    class IsoscelesTriangle : Figure
    {
        public IsoscelesTriangle(double a, double b)
        {
            this.a = a; this.b = b;
        }

        public double Measure()
        {
            return 0.5 * b * Math.Sqrt(Math.Pow(a,2) - (Math.Pow(b,2) / 4));
        }
    }
}