namespace Fabian.Week07._07Car
{
    public class Tank
    {
        private string _Name;
        private double _MaxCapacity;
        private double _Capacity;

        public string Name { get => _Name; }
        public double MaxCapacity { get => _MaxCapacity; }
        public double Capacity
        {
            get => _Capacity;
            set => _Capacity = value;
        }

        public Tank(string name, double maxCapacity)
        {
            _Name = name;
            _MaxCapacity = maxCapacity;
            _Capacity = maxCapacity;
        }
    }
}
