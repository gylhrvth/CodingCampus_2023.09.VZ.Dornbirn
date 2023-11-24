
namespace Selina.Week08.Geometry_Interface
{
    public class Rectangle : IGeometry
    {
        private double _SideA;
        private double _SideB;
        private string _Name;
        public Rectangle(double sideA, double sideB, string name)
        {
            _SideA = sideA;
            _SideB = sideB;
            _Name = name;
        }
        public virtual double GetCircumference()
        {
            return 2 * _SideA + 2 * _SideB;
        }
        public virtual double GetArea()
        {
            return _SideA * _SideB;
        }
        public virtual string GetName()
        {
            return _Name;
        }
    }
}
