using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle : Figure
    {
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Measure()
        {
            return a * b;
        }
    }
}
