using System;
using System.Linq;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            var figures = new double[] 
            {
                new FigureCreation().CreateSquare(2).Measure(),
                new FigureCreation().CreateSquare(8).Measure(),
                new FigureCreation().CreateEquilateralTriangle(7).Measure(),
                new FigureCreation().CreateIsoscelesTriangle(5, 1).Measure(),
                new FigureCreation().CreateRightTriangle(3, 9).Measure(),
            };

            figures.ToList().ForEach(figure => Console.WriteLine(figure));
        }
    }
}