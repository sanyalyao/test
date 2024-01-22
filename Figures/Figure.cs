namespace Homework1
{
    class Figure
    {
        protected double A { get; set; }
        protected double B { get; set; }
        protected double C { get; set; }

        protected Figure(double a, double b, double c)
        {
            A = a; 
            B = b; 
            C = c;
        }

        protected Figure(double a)
        {
            A = a;
        }

        protected Figure(double a, double b)
        {
            A = a;
            B = b;
        }

        public virtual double Measure()
        {
            return double.NaN;
        }
    }
}
