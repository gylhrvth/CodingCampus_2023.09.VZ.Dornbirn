using System;
namespace David.Week08.Geometry
{
	public class Triangle : Geometry
	{
		private double _Length;

		public Triangle(double length)
		{
			_Length = length;
		}

        public override double getCircumfence()
        {
            return _Length * Math.PI;
        }
        public override double getArea()
        {
            return _Length * 3;
        }
    }
}

