using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Geometry
{
    internal class HausVomNikolaus : Geometry
    {
        private double _Length;
        private Square _Square;
        private Triangle _Triangle;

        public HausVomNikolaus(double length)
        {
            _Length = length;
            _Square = new Square(length);
            _Triangle = new Triangle(length, length, length);
        }


        public override double GetCircumference()
        {
            return 5 * _Length;
        }


        public override double GetArea()
        {
            return _Square.GetArea() + _Triangle.GetArea();
        }
    }
}
