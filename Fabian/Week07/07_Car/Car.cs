using static Fabian.Selftest_SP.TowersOfHanoi;

namespace Fabian.Week07._07Car
{
    public class Car
    {
        public enum CarDriveType
        {
            Petrol,
            Diesel,
            Gas,
            Electricity
        }
        protected Tank _Tank;
        protected string _Producer;
        protected string _Model;
        protected double _Consumption;
        protected Engine _Engine;
        protected CarDriveType _DriveType;
        protected double _Weight;
        private int _Trip;

        public string Model { get => _Model; }
        public Tank Tank { get => _Tank; }
        public Engine Engine { get => _Engine; set => _Engine = value; }
        public int Trip { get => _Trip; set => _Trip = value; }
        public CarDriveType DriveType { get => _DriveType; }
        public double Consumption { get => _Consumption; set => _Consumption = value; }


        public Car(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType)
        {
            _Producer = producer;
            _Model = model;
            _Engine = engine;
            _Tank = (carDriveType == CarDriveType.Electricity) ? new Battery(tank.Name, tank.MaxCapacity) : new FuelTank(tank.Name, tank.MaxCapacity);
            _Weight = weight;
            _DriveType = carDriveType;
            _Consumption = _Engine.Power / _Weight;
            _Trip = 0;
        }

        public int Drive(int kilometer)
        {
            int driven = 0;
            //SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
            while (driven < kilometer)
            {
                if (_Tank.Capacity - _Consumption < 0)
                {
                    PrintCarStatus();
                    return driven;
                }
                _Engine.IsBroken = _Engine.CheckIfBroken(this);
                if (_Engine.IsBroken)
                {
                    PrintCarStatus();
                    return driven;
                }             
                _Tank.Capacity -= _Consumption;
                _Engine.DistanceTravelled++;
                _Trip++;
                driven++;
            }
            SetConsoleColor(ConsoleColor.Cyan, $"{_Model} stopped!");
            return driven;
        }

        private void PrintCarStatus()
        {
            string unit = (_DriveType == CarDriveType.Electricity) ? "kWh" : "L";
            string type = (_DriveType == CarDriveType.Electricity) ? "battery" : "tank";
            Console.Write($"The {type} status is: {_Tank.Capacity:N2}{unit}.");
            if (_Engine.IsBroken)
                SetConsoleColor(ConsoleColor.Red, " The Engine is broken!");
            else
                Console.WriteLine(" The Engine is not broken!");         
        }

        public void SelfRepair()
        {
            SetConsoleColor(ConsoleColor.DarkRed, "Car stopped!");
            Console.WriteLine($"The engine of {_Model} has been repaired after {_Engine.DistanceTravelled} km!");
            _Engine = new Engine("selfrepair", _Engine.Power);
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
        }
    }
}
