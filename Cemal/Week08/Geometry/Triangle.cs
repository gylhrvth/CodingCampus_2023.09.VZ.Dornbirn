using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Geometry
{
    public class Triangle : Geometryclass
    {
        private double _Length1;

        public Triangle(double length1) 
        {
            _Length1 = length1;
        }

        public override double getCircumference()
        {
            return _Length1 * 3;
        }

        public override double getArea()
        {
            return (_Length1 * _Length1) * Math.Sqrt(3) / 4;
        }
    }
}
