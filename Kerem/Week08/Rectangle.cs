using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08
{
    internal class Rectangle  : Geometry
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override double CircumFerence()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rectangle");
            Console.ForegroundColor = ConsoleColor.White;

            return Math.Pow(_length,2) + Math.Pow(_width,2);
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }

}
