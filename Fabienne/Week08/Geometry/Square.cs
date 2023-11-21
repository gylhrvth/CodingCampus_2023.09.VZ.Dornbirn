using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.Geometry
{
    public class Square : Rectangle
    {
        private double _Length;
        public Square(double length) : base( length, length)
        {
            _Length = length;
        }
        public override double GetArea()
        {
            return _Length * _Length;
        }
        public override double GetCircumference()
        {
            return _Length * 3;
        }
    }
}