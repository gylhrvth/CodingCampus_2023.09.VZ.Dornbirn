using System;
namespace Mohammed.Week07.Geometry
{ 
    //abgeleitete klasse vererbt
	public class Circle : Geometry
	{
		private double radius;

		public Circle(double radius)
		{
			this.radius = radius;
		}

        public virtual double GetCirumFerence()
        {
			return 2 * Math.PI * radius;
        }

        public virtual double GetArea()
        {
            return Math.PI * (radius * radius);
        }


    }
}

