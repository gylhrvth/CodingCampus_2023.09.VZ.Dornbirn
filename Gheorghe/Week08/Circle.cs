using Gheorghe.Week07.Vererbung;
using System.Runtime.CompilerServices;

namespace Gheorghe.Week08
{
    internal class Circle :Geometry
    {
        private double _radius;
        public Circle(double radius) 
         {
           _radius = radius; 

        }




        public virtual double GetCircumference()
        {
            return 2 * Math.PI * _radius;

        }


        public virtual double getArea()
        {
            return Math.PI * (_radius * _radius);
        }
    }

}

