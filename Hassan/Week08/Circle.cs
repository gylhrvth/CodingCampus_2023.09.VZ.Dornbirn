using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week08
{
    public class Circle : Geometry
    {
        private double _Radius;

        public Circle(double length) 
        {
            _Radius = length;
        }

        public override double GetCircumference()
        {
            return 2 * Math.PI * _Radius;
        }

        public override double GetArea()
        {
            return Math.Pow(_Radius, 2) * Math.PI;
        }
    }
}
