using Patrick.Week08.GeometrieAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.GeometrieInterface
{
    internal class Circle : IGeometrie
    {
        private double _Radius;



        public Circle(double radius)
        {
            _Radius = radius;
        }


        public double GetArea()
        {
            return _Radius * _Radius * double.Pi;
        }

        public double GetCircumference()
        {
            return 2 * double.Pi * _Radius;
        }
    }

}
