using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week08
{
    internal class Triangle : Geometry
    {
        private double _a;

           public Triangle(double a)
        {
            _a = a;
        }

        public override double GetCircumfence()
        {
            return _a * 3;
        }

        public override double GetArea()
        {
            return Math.Pow(_a,2) * Math.Sqrt(3)/4;
        }

    }
}
