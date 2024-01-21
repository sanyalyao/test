using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    /// <summary>
    /// прямоугольный
    /// </summary>
    class RightTriangle : Figure
    {
        public RightTriangle(double a, double b)
        {
            this.a = a; this.b = b;
        }

        public double Measure()
        {
            return 0.5 * a * b;
        }
    }
}
