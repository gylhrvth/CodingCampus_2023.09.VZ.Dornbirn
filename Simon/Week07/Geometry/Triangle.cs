using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.Geometry
{
    public class Triangle : Geometry
    {
        public double _Length;

        public Triangle(double length)
        {
            _Length = length;
        }

        public override double getCircumfrence()
        {
            return _Length * 3;
        }

        public override double getArea()
        {
            return Math.Pow(_Length * _Length, 2);
        }



    }
}
