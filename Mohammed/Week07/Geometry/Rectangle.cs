using System;

namespace Mohammed.Week05.Geometry
{
    public class Rectangle : Geometry
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }

        public virtual double GetCirumFerence()
        {
            return 2 * (width + height);
        }

        public virtual double GetArea()
        {
            return width * height;
        }

    }

}

