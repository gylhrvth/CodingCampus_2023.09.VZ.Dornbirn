
namespace Selina.Week08.Geometry
{
    public class Rectangle : Geometry
    {
        private double sideA;
        private double sideB;
        private string name;
        public Rectangle(double sideA, double sideB, string name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.name = name;
        }
        public override double GetCircumference()
        {
            return 2 * sideA + 2 * sideB;
        }
        public override double GetArea()
        {
            return sideA * sideB;
        }
        public override string GetName()
        {
            return name;
        }
    }
}
