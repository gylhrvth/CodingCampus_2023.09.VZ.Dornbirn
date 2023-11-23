using System;
namespace David.Week08.Geometry
{
	public class Circle : Geometry
	{
		private double _Radius;

		public Circle(double radius)
		{
			_Radius = radius;
		}

        public override double getCircumfence()
        {
			return _Radius * Math.PI;
        }

        public override double getArea()
        {
			//return Math.PI * (_Radius * _Radius);
			return Math.PI * Math.Pow(_Radius, 2);
            //return double.Pi * Math.Pow(_Radius, 2);

        }
    }
}