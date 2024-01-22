namespace Homework1
{
    class Rectangle : Figure
    {
        public Rectangle(double a, double b) : base(a, b) { }

        public override double Measure()
        {
            return A * B;
        }
    }
}
