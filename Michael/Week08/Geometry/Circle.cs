using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class Circle : Geometry
    {
        private double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }


        public override double GetCircumference()
        {
            return Math.PI * 2 * _Radius;
        }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(_Radius, 2);
        }
    }
}
