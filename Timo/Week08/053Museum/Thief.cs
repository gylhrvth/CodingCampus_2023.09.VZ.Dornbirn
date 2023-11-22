
namespace Timo.Week08._053Museum
{
    public class Thief : Visitor
    {
        private int _Speed;
        private double _MaxCapacity;
        private double _Capacity;

        public Thief(string name, int speed, double maxCapacity) : base(name)
        {
            _Name = name;
            _Speed = speed;
            _MaxCapacity = maxCapacity;
            _Capacity = maxCapacity;
        }
    }
}
