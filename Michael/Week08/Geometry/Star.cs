using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class Star : Geometry
    {
        private double _Length;
        private Triangle _Triangle;
        private Square _Square;

        public Star(double length)
        {
            _Length = length;
            _Triangle = new Triangle(length, length, length);
            _Square = new Square(length);
        }


        public override double GetCircumference()
        {
            //return 4 * ( (new Triangle(_Length, _Length, _Length)).GetCircumference() - _Length);
            return 8 * _Length;
        }


        public override double GetArea()
        {
            return 4 * _Triangle.GetArea() + _Square.GetArea();
        }
    }
}
