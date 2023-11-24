using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerem.Week08;

namespace Kerem.Week08
{
    internal class Square : Geometry
    {
        private double _length;

        public Square(double length) 
        {
            _length = length;
        }
        public override double CircumFerence()
        {

            return _length *4;
        }
        public override double GetArea()
        {
            return _length * _length;
        }
        public override string ToString()
        {
            return "Square";
        }
    }

}
