using System;
namespace David.Week08.GeometryInterface
{
	public class TriangleInterface
	{
        public class Triangle : GeometryInterface
        {
            private double _Length;

            public Triangle(double length)
            {
                _Length = length;
            }

            public double getCircumfence()
            {
                return _Length * Math.PI;
            }
            public double getArea()
            {
                return _Length * 3;
            }
        }
    }
}

