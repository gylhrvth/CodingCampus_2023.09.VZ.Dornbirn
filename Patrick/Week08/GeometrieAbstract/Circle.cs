using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieAbstract
{
    internal class Circle : Geometrie
    {
        private double _Radius;



        public Circle(double radius)
        {
            _Radius = radius;
        }


        public override double GetArea()
        {
            return _Radius * _Radius * double.Pi;
        }

        public override double GetCircumference()
        {
            return 2 * double.Pi * _Radius;
        }
    }

}
