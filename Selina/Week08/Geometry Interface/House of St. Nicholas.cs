
namespace Selina.Week08.Geometry_Interface
{
    public class House_of_St : IGeometry
    {
        private double _SideA;
        private double SideB;
        private double SideC;
        private string Name;
        public House_of_St(double sideA, double sideB, string name, double sideC)
        {
            _SideA = sideA;
            SideB = sideB;
            Name = name;
            SideC = sideC;
        }
        public virtual double GetCircumference()
        {
            return 2 * _SideA + 2 * SideB + (_SideA + SideB + SideC);
        }
        public virtual double GetArea()
        {
            return _SideA * SideB + Math.Sqrt(3) / 2 * _SideA;
        }
        public string GetName()
        {
            return Name;
        }

    }
}
