using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week08
{
    public class Triangle : Geometry
    {
        private double _length;


        public Triangle(double length) 
        {
            _length = length;
        }

        public override double GetCircumference()
        {
            return 3 * _length;
        }

        public override double GetArea()
        {
            double height = _length * Math.Pow(_length, 1 / 3);
            return _length * height / 2;
        }
    }
}
