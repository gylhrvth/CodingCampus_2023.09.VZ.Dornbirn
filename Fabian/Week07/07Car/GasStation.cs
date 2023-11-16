using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._07Car
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
            string unit = (car.DriveType == Car.CarDriveType.Strom) ? "kWh" : "L";
            string type = (car.DriveType == Car.CarDriveType.Strom) ? "battery" : "tank";
            SetConsoleColor(ConsoleColor.DarkYellow, "Car stopped!");
            Tank t = car.Tank;
            t.Capacity = (t.Capacity + value < t.MaxCapacity) ? t.Capacity + value : t.MaxCapacity;
            Console.WriteLine($"The {type} has been refilled by {value}{unit} in the Gasstation {_Name} after {car.Trip} km!");
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
        }
    }
}
