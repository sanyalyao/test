namespace Homework8.Task_1.Figures
{
    class Circle : BaseFigure
    {
        private int Radius { get; set; }

        public Circle(int radius) : base(radius) 
        { 
            Radius = radius;
        }

        public override double MeasureArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double MeasurePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
