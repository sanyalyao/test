using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    /// <summary>
    /// равносторонний
    /// </summary>
    class EquilateralTriangle : Figure
    {
        public EquilateralTriangle(double a) 
        {
            this.a = a;
        }

        public double Measure()
        {
            return (Math.Pow(a, 2) * Math.Sqrt(3))/4;
        }
    }
}