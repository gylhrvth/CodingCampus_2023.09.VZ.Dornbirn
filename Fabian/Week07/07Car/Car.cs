namespace Fabian.Week07._07Car
{
    public class Car
    {
        public enum CarDriveType
        {
            Benzin,
            Diesel,
            Gas,
            Strom
        }
        private Tank _Tank;
        private string _Producer;
        private string _Model;
        private Engine _Engine;
        private CarDriveType _CarDriveType;
        private double _Weight;

        public string Model { get => _Model; }
        public Car(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType)
        {
            _Producer = producer;
            _Model = model;
            _Engine = engine;
            _Tank = tank;
            _Weight = weight;
            _CarDriveType = carDriveType;          
        }

        public int Drive (int kilometer)
        {
            int driven = 0;
            double consumption = _Engine.Power / _Weight;
            while(driven < kilometer)
            {
                if (_Tank.Capacity - consumption < 0)
                {
                    Console.WriteLine("{0} is empty at {1} km and gets refilled", _Model,  driven);
                    FillTank(10);
                }
                _Tank.Capacity -= consumption;
                driven++;
                _Engine.DistanceTravelled++;
            }

            return driven;
        }
        public void FillTank(double value)
        {
            _Tank.Capacity += value;
        }
    }
}
