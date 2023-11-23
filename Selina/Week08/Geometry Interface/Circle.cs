namespace Selina.Week08.Geometry_Interface
{
    public class Circle : IGeometry
    {
        private double _Radius;
        private string _Name;
        public Circle(double radius, string name)
        {
            _Radius = radius;
            _Name = name;
        }
        public virtual double GetCircumference()
        {
            return 2 * Math.PI * _Radius;
        }
        public virtual double GetArea()
        {
            return Math.PI * _Radius * _Radius;
        }
        public virtual string GetName()
        {
            return _Name;
        }
    }
}
