using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.InterfaceGeometry
{
    public class Circle : Geometry
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public  double getCircumference()
        {
            return 2 * _radius * Math.PI;
        }

        public  double getArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

    }
}
