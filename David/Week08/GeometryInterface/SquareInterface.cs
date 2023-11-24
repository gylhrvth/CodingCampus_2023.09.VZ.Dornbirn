using System;
namespace David.Week08.GeometryInterface
{
	
        public class Square :RectangleInterface 
        {
            private double _Length;

            public Square(double length) : base(length, length)
            {
                _Length = length;
            }

            public virtual double getArea()
            {
                return Math.Pow(_Length, 2);
            }

            public virtual double getCircumfence()
            {
                return _Length * 4;
            }


        }
    
}

