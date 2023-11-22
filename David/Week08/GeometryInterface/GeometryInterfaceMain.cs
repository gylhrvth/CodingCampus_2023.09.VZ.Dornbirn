using System;
namespace David.Week08.GeometryInterface
{
	public class GeometryInterfaceMane
	{
        public interface GeometryMain
        {
            public static void Start()
            {

                Triangle triangle = new Triangle(4);
                Circle circle = new Circle(5);
                Rectangle rectangle = new Rectangle(1, 2);
                Square square = new Square(3);

                List<Geometry> geometries = new List<Geometry>()
            {
                triangle,
                circle,
                rectangle,
                square
            };

                double sumArea = 0;
                double sumCircumfence = 0;

                foreach (Geometry element in geometries)
                {
                    Console.WriteLine("Der Umfang beträgt = " + element.getArea() + "cm");
                    Console.WriteLine("Die Fläche beträgt = " + element.getCircumfence() + "cm");
                }

                foreach (Geometry element in geometries)
                {
                    sumArea += element.getArea();
                    sumCircumfence += element.getCircumfence();
                }

                Console.WriteLine($"The sum of the Areas is : {sumArea}");
                Console.WriteLine($"The sum of the Circumfences is : {sumCircumfence}");
            }
        }
    }
}

