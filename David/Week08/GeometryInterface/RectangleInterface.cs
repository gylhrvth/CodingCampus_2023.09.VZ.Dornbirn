using System;
namespace David.Week08.GeometryInterface
{
	public class RectangleInterface : GeometryInterface
    {
       
            private double _Width;
            private double _Height;

            public RectangleInterface(double with, double height)
            {
                _Width = with;
                _Height = height;
            }

            public double getArea()
            {
                return _Width * _Height;
            }

            public double getCircumfence()
            {
                return (_Width * 2) + (_Height * 2);
            }


        
    }
}

