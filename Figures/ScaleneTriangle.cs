using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    /// <summary>
    /// разносторонний
    /// </summary>
    class ScaleneTriangle : Figure
    {
        public ScaleneTriangle(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }

        public double Measure()
        {
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
