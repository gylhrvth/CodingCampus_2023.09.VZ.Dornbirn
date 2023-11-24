using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.AbstraktGeometry
{
    public class StartGeometry
    {
        public static void Start()
        {

            List<Geometry> GeometryList = new List<Geometry>();


            Circle circle = new Circle(3.2);
            Rectangle rectangle = new Rectangle(2.4, 3.3);
            Square square = new Square(3.2322);
            Triangle triangle = new Triangle(6.3);

            GeometryList.Add(circle);
            GeometryList.Add(rectangle);
            GeometryList.Add(square);
            GeometryList.Add(triangle);

            double sumArea = 0;
            foreach (Geometry g in GeometryList)
            {
                sumArea += g.getArea();
            }

            Console.WriteLine("Gesamtfläche ist von allen: {0}", sumArea);

            double sumCircumference = 0;
            foreach (Geometry g in GeometryList)
            {
                sumCircumference += g.getCircumference();
            }

            Console.WriteLine("Gesamtumfang ist von allen: {0}", sumCircumference);

        }
    }
}
