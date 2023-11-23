using System;
namespace David.Week08.Geometry
{
	public class Square : Rectangle
	{
		private double _Length;

		public Square(double length) : base(length,length)
		{
			_Length = length;
		}

        public override double getArea()
        {
            return Math.Pow(_Length, 2);
        }

        public override double getCircumfence()
        {
            return _Length * 4;
        }


    }
}