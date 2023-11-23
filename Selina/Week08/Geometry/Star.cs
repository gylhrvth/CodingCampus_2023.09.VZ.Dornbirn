namespace Selina.Week08.Geometry
{
    public class Star : Geometry
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private string name;
        public Star(double sideA, double sideB, double sideC, string name)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.name = name;
        }
        public override double GetCircumference()
        {
            return (sideA + sideB + sideC) * 4 + 4 * sideC;
        }
        public override double GetArea()
        {
            return Math.Sqrt(3) / 2 * sideA * 4 + sideC * sideC;
        }
        public override string GetName()
        {
            return name;
        }
    }
}
