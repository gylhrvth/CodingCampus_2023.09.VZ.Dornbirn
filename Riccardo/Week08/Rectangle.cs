using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week08
{
    internal class Rectangle : Geometry
    {
        private double _a;
        private double _b;

        public Rectangle (double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double GetCircumfence()
        {
            return 2 * _a + 2 * _b;
        }

        public override double GetArea()
        {
            return _a * _b;
        }
    }
}
