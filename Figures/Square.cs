using System;

namespace Homework1
{
    class Square : Figure
    {
        public Square(double a) : base(a) { }

        public override double Measure()
        {
            return Math.Pow(A, 2);
        }
    }
}
