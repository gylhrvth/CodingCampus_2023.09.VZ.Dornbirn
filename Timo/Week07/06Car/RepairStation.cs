using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Timo.ColorOfConsole;

namespace Timo.Week07._06Car
{
    public class RepairStation
    {
        private string _Name;

        public RepairStation(string name)
        {
            _Name = name;
        }

        public void ChangeEngine(Car car)
        {
            SetConsoleColor(ConsoleColor.DarkRed, "Car stopped!");
            Console.WriteLine($"The engine of {car.Model} has been switched in the Repairstation {_Name} after {car.Engine.DistanceTravelled} km!");
            car.Engine = new Engine("Engine", 150);
            Console.WriteLine("The engine is starting");
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
        }
    }
}
