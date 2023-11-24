using System;


namespace Riccardo.Week08
{
    internal class Square : Geometry
    {
        private double _a;

        public Square(double a)
        {
            _a = a;
        }

        public override double GetCircumfence()
        {
            return 4 * _a;
        }

        public override double GetArea()
        {
            return _a * _a;
        }
    }
}
