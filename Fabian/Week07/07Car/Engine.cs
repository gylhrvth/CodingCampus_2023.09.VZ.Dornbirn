namespace Fabian.Week07._07Car
{
    public class Engine
    {
        private string _Name;
        private int _Power;
        private bool _IsBroken;
        private int _DistanceTravelled;

        public int Power { get => _Power; }
        public bool IsBroken
        {
            get => _IsBroken;
            set => _IsBroken = value;
        }
        public int DistanceTravelled
        {
            get => _DistanceTravelled;
            set => _DistanceTravelled = value;
        }

        public Engine(string name, int power)
        {
            _Name = name;
            _Power = power;
            _IsBroken = false;
            _DistanceTravelled = 0;
        }
    }
}
