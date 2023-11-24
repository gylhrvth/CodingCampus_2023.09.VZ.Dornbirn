using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.Geometry
{
    public class Rectangle : Geometry
    {
        private double _Length;
        private double _Height;
        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }
        public /*override*/ double GetArea()
        {
            return _Length * _Height;
        }
        public /*override*/ double GetCircumference()
        {
            return (_Height + _Length) * 2;
        }
    }
}