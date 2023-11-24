using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Geometry.Geometry
{
    public class Circle : Geometryclass
    {
        private double _Radius;

        public Circle(double radius) 
        { 
            _Radius = radius;
        }

        public override double getCircumference()
        {
            return (2 * _Radius * Math.PI);
        }

        public override double getArea()
        {
            return Math.PI * Math.Pow(_Radius, 2);
        }
    }
}
