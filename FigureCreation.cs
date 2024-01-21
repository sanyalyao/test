using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FigureCreation
    {
        public RightTriangle CreateRightTriangle(double a, double b)
        {
            return new RightTriangle(a, b);
        }

        public EquilateralTriangle CreateEquilateralTriangle(double a)
        {
            return new EquilateralTriangle(a);
        }

        public IsoscelesTriangle CreateIsoscelesTriangle(double a, double b)
        {
            return new IsoscelesTriangle(a, b);
        }

        public Square CreateSquare(double a)
        {
            return new Square(a);
        }

        public Rectangle CreateRectangle(double a, double b)
        {
            return new Rectangle(a, b);
        }
    }
}
