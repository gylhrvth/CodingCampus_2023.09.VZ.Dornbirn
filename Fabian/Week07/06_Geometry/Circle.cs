namespace Fabian.Week07._06_Geometry
{
    public class Circle : Geometry
    {
        private double _Radius;

        public Circle(double length)
        {
            _Radius = length;
        }

        public override double GetCircumference()
        {
            return 2 * Math.PI * _Radius;
        }

        public override double GetArea()
        {
            return Math.Pow(_Radius, 2) * Math.PI;
        }
    }
}
