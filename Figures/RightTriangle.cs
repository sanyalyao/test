namespace Homework1
{
    /// <summary>
    /// прямоугольный
    /// </summary>
    class RightTriangle : Figure
    {
        public RightTriangle(double a, double b) : base(a, b) { }

        public override double Measure()
        {
            return 0.5 * A * B;
        }
    }
}
