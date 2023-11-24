using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Timo.ColorOfConsole;

namespace Timo.Week07._06Car
{
    public class GasStation
    {
        public string _Name;

        public GasStation(string name)
        {
            _Name = name;
        }

        public void FillTank(Car car, double value)
        {
            string unit = (car.DriveType == Car.CarDriveType.Electricity) ? "kWh" : "L";
            string type = (car.DriveType == Car.CarDriveType.Electricity) ? "battery" : "tank";
            SetConsoleColor(ConsoleColor.DarkYellow, "Car stopped!");
            Tank t = car.Tank;
            t.Capacity = (t.Capacity + value < t.MaxCapacity) ? t.Capacity + value : t.MaxCapacity;
            Console.WriteLine($"The {type} has been refilled by {value}{unit} in the Gasstation {_Name} after {car.Trip} km!");
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
        }
    }
}
