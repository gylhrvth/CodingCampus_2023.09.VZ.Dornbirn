using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    internal class Triangle
    {
        private double _Length;

        public Triangle(double length)
        {
            _Length = length;
        }

        public double Length
        { get => _Length; }
    }
}
