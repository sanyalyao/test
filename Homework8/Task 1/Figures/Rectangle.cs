namespace Homework8.Task_1.Figures
{
    class Rectangle : BaseFigure
    {
        public Rectangle(int sideA, int sideB) : base(sideA, sideB)
        {
        }

        public override double MeasureArea()
        {
            return SideA * SideB;
        }

        public override double MeasurePerimeter()
        {
            return 2 * (SideA * SideB);
        }
    }
}
