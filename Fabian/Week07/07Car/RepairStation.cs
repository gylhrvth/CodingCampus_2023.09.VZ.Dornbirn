using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._07Car
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
