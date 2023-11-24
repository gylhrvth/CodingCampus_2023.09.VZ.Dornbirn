using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week08
{
    public class Triangle:Geometry
    {
        private double _Length;
        public Triangle(double length) 
        { 
            _Length = length;
        }

        public override double getArea()
        {
            return _Length * _Length * Math.Sqrt(3) / 4;
        }

        public override double getCircumference()
        {
            return 3 * _Length;
        }
    }
}
