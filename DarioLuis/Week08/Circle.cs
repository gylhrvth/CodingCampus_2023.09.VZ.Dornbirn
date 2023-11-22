using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week08
{
    public class Circle:Geometry
    {
        private double _Radius;
        public Circle(double radius) 
        {
            _Radius = radius;
        }

        public override double getArea()
        {
            return _Radius * _Radius *Math.PI;
        }

        public override double getCircumference()
        {
            return 2 * _Radius * Math.PI;
        }
    }
}
