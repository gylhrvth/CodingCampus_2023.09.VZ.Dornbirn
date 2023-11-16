namespace Fabian.Week07._06_Geometry
{
    public class Rectangle : Geometry
    {
        private double _Length;
        private double _Height;  

        public Rectangle(double length, double height)
        {
            _Length = length;
            _Height = height;
        }

        public override double GetCircumference()
        {
            return 2 * _Length + 2 * _Height;
        }

        public override double GetArea()
        {
            return _Length * _Height;
        }
    }
}
