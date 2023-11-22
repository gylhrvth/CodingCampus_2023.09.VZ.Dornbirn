using System;
namespace Mohammed.Week07.Geometry
{
	public class GeometryList
	{
		public static void Start()
		{
            List<Geometry> geometries = new List<Geometry>();

            geometries.Add(new Circle(9));
            geometries.Add(new Square(3));
            geometries.Add(new Rectangle(5, 10));
			geometries.Add(new Triangle(6, 4));


            foreach (Geometry geometry in geometries)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Umfang: {0, 10:N3}", geometry.GetCirumFerence());
                Console.WriteLine("Fläche: {0, 10:N3}", geometry.GetArea());
            }

            double totalCircumference = 0;
			double totalArea = 0;

			foreach(Geometry geometry in geometries)
			{
                Console.ForegroundColor = ConsoleColor.Green;
                totalCircumference += geometry.GetCirumFerence();
                totalArea += geometry.GetArea();
            }

			Console.WriteLine("Gesamtumfang: {0}", totalCircumference);
			Console.WriteLine("Gesamtfläche: {0}", totalArea);

			
		}
	}
}

