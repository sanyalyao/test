using System;

namespace Homework1
{
    /// <summary>
    /// равнобедренный
    /// </summary>
    class IsoscelesTriangle : Figure
    {
        public IsoscelesTriangle(double a, double b) : base(a, b) { }

        public override double Measure()
        {
            return 0.5 * B * Math.Sqrt(Math.Pow(A,2) - (Math.Pow(B,2) / 4));
        }
    }
}