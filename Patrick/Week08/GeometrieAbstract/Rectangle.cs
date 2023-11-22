using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieAbstract
{
    internal class Rectangle : Geometrie
    {
        private double _Width;
        private double _Height;


        public Rectangle(double Width, double Height)
        {
            _Width = Width;
            _Height = Height;
        }

        public override double GetArea()
        {
            return _Width * _Height;
        }
        public override double GetCircumference()
        {
            return (_Width * 2) + (_Height * 2);
        }

    }
}
