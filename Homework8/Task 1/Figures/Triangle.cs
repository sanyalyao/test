namespace Homework8.Task_1.Figures
{
    class Triangle : BaseFigure
    {
        private int SideC { get; set; }

        public Triangle(int sideA, int sideB, int sideC) : base(sideA, sideB) 
        {
            SideC = sideC;
        }

        public override double MeasureArea()
        {
            var p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double MeasurePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
