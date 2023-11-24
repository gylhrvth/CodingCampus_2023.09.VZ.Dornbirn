
namespace Selina.Week08.Geometry_Interface
{
    public class Star : IGeometry
    {
        private double _SideA;
        private double _SideB;
        private double _SideC;
        private string _Name;
        public Star(double sideA, double sideB, double sideC, string name)
        {
            _SideA = sideA;
            _SideB = sideB;
            _SideC = sideC;
            _Name = name;
        }
        public virtual double GetCircumference()
        {
            return (_SideA + _SideB + _SideC) * 4 + 4 * _SideC;
        }
        public virtual double GetArea()
        {
            return Math.Sqrt(3) / 2 * _SideA * 4 + _SideC * _SideC;
        }
        public virtual string GetName()
        {
            return _Name;
        }
    }
}
