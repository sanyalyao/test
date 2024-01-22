using System;

namespace Homework1
{
    /// <summary>
    /// равносторонний
    /// </summary>
    class EquilateralTriangle : Figure
    {
        public EquilateralTriangle(double a) : base(a) { }

        public override double Measure()
        {
            return (Math.Pow(A, 2) * Math.Sqrt(3))/4;
        }
    }
}