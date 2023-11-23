
namespace Selina.Week08.Geometry
{
    public class Circle : Geometry
    {
        private double radius;
        private string name;
        public Circle(double radius, string name)
        {
            this.radius = radius;
            this.name = name;
        }
        public override double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override string GetName()
        {
            return name;
        }
    }
}
