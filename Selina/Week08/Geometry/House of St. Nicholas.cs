
namespace Selina.Week08.Geometry
{
    public class House_of_St : Geometry
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private string name;
        public House_of_St(double sideA, double sideB, string name, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.name = name;
            this.sideC = sideC;
        }
        public override double GetCircumference()
        {
            return 2 * sideA + 2 * sideB + (sideA + sideB + sideC);
        }
        public override double GetArea()
        {
            return sideA * sideB + Math.Sqrt(3) / 2 * sideA;
        }
        public override string GetName()
        {
            return name;
        }

    }
}
