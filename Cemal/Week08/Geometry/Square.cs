using Cemal.Week08.Geometry.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Geometry
{
    public class Square : Rectangle
    {
        private double _Length;

        public Square(double length) : base(length, length)
        {
            _Length = length;
        }

        public override double getArea()
        {
            return _Length * 4;
        }

        public override double getCircumference()
        {
            return _Length * 2;
        }
    }
}
