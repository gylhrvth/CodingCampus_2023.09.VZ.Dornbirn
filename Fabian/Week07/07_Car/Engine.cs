namespace Fabian.Week07._07Car
{
    public class Engine
    {
        private Random _Random = new();
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

        public bool CheckIfBroken(Car car)
        {
            double breakProbability = 0;

            if (_DistanceTravelled <= 20000)
                breakProbability = 0.00003;
            else if (_DistanceTravelled <= 50000)
                breakProbability = 0.00008;
            else if (_DistanceTravelled <= 150000)
                breakProbability = 0.00013;
            else if (_DistanceTravelled <= 300000)
                breakProbability = 0.00018;
            else if (_DistanceTravelled <= 400000)
                breakProbability = 0.0005;
            else if (_DistanceTravelled <= 800000)
                breakProbability = 0.0008;

            return (car.GetType() == typeof(CrapCar)) ? _Random.NextDouble() <= breakProbability * 2 : _Random.NextDouble() <= breakProbability;
        }    
    }
}

