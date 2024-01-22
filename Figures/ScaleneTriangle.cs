using System;

namespace Homework1
{
    /// <summary>
    /// разносторонний
    /// </summary>
    class ScaleneTriangle : Figure
    {
        public ScaleneTriangle(int a, int b, int c) : base(a, b, c) { }

        public override double Measure()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
