using System;
using System.Linq;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            var figureCreater = new FigureCreation();

            var figures = new double[] 
            {
                figureCreater.CreateSquare(2).Measure(),
                figureCreater.CreateSquare(8).Measure(),
                figureCreater.CreateEquilateralTriangle(7).Measure(),
                figureCreater.CreateIsoscelesTriangle(5, 1).Measure(),
                figureCreater.CreateRightTriangle(3, 9).Measure(),
            };

            figures.ToList().ForEach(figure => Console.WriteLine(figure));
        }
    }
}