using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._05Geometry
{
    public class Rectangle
    {
        private double _Length;
        private double _Height;
        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }

        public double Length
        { get => _Length; }
        public double Height
        { get => _Height; }
    }
}
