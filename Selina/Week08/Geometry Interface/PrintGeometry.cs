
namespace Selina.Week08.Geometry_Interface
{
    class PrintGeometry
    {
        public static void Start()
        {
            List<IGeometry> geometries = new List<IGeometry>();

            geometries.Add(new Circle(5, "Kreis"));
            geometries.Add(new Square(10, "Quadrat"));
            geometries.Add(new Rectangle(20, 15, "Rechteck"));
            geometries.Add(new Triangle(10, 15, 30, "Dreieck"));
            geometries.Add(new Star(20, 30, 15, "Stern"));
            geometries.Add(new House_of_St(20, 49, "Haus vom Nikolaus", 15));

            Print(geometries);
        }

        public static void Print(List<IGeometry> geometries)
        {
            double area = 0;
            string name = null;

            foreach (IGeometry geometry in geometries)
            {
                double circumference = geometry.GetCircumference();
                area = geometry.GetArea();
                name = geometry.GetName();

                Console.WriteLine($"{name,-17} =>     U = {circumference,6:f2} cm    A = {area,6:f2} cm");
            }
        }
    }
}
