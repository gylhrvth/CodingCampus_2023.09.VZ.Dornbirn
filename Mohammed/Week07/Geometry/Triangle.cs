using System;
namespace Mohammed.Week07.Geometry
{
	public class Triangle : Geometry
	{ 
		private double tbase;
		private double height;

		public Triangle(double tbase, double height)
		{
			this.tbase = tbase;
			this.height = height;
		}

        public virtual double GetArea()
        {
            return (tbase * height) / 2;
        }

        public virtual double GetCirumFerence()
        {
            return tbase + 2 * Math.Sqrt((tbase * tbase / 4) + (height * height));
        }


    }
}

