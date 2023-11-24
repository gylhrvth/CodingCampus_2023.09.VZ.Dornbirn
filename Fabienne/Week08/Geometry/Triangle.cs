using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.Geometry
{
    public class Triangle : Geometry
    {
        private double _Length;
        public Triangle(double length)
        {
            _Length = length;
        }
        public /*override*/ double GetArea()
        {
           return _Length * _Length;
        }
        public /*override*/ double GetCircumference()
        {
            return _Length * 3;
        }
    }
}