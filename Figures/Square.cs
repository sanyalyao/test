﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Square : Figure
    {
        public Square(double a)
        {
            this.a = a;
        }

        public double Measure()
        {
            return Math.Pow(a, 2);
        }
    }
}
