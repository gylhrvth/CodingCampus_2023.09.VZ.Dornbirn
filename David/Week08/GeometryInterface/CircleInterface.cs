using System;
namespace David.Week08.GeometryInterface
{
	public class CircleInterface
	{
        public class Circle : GeometryInterface
        {
            private double _Radius;

            public Circle(double radius)
            {
                _Radius = radius;
            }

            public virtual double getCircumfence()
            {
                return _Radius * Math.PI;
            }

            public virtual double getArea()
            {
                //return Math.PI * (_Radius * _Radius);
                return Math.PI * Math.Pow(_Radius, 2);
                //return double.Pi * Math.Pow(_Radius, 2);

            }
        }
    }
}

