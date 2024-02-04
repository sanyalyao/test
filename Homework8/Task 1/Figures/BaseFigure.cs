namespace Homework8.Task_1.Figures
{
    public abstract class BaseFigure
    {
        protected int SideA { get; set; }
        protected int SideB { get; set; }

        protected BaseFigure(int sideA, int sideB)
        { 
            SideA = sideA;
            SideB = sideB;
        }

        protected BaseFigure(int sideA)
        {
            SideA = sideA;
        }

        public abstract double MeasureArea();
        public abstract double MeasurePerimeter();
    }
}
