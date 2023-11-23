using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Geometry
{
    internal class Triangle : Geometry
    {
        private double _length;
        private double _height;

        public Triangle(double length, double height)
        {
            _length = length;
            _height = height;
        }
        public override double CircumFerence()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Triangle:");
            Console.ForegroundColor = ConsoleColor.White;
            return _length + _length + _length;
        }
        public override double GetArea()
        {
            return _length * _height / 2;
        }
    }
}
