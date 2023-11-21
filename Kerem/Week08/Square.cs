using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Square");
            Console.ForegroundColor = ConsoleColor.White;

            return _length *4;
        }
        public override double GetArea()
        {
            return _length + _length;
        }
    }

}
