using static Fabian.Selftest_SP.TowersOfHanoi;
namespace Fabian.Week07._07Car
{
    public class SelfRepairingCar : Car
    {
        public SelfRepairingCar(string producer, string model, Engine engine, double weight, Tank tank, CarDriveType carDriveType) : base(producer, model, engine, weight, tank, carDriveType)
        {
            
        }

        public override void SelfRepair()
        {
            SetConsoleColor(ConsoleColor.DarkRed, "Car stopped!");
            Console.WriteLine($"The engine of {_Model} has been selfrepaired after {_Engine.DistanceTravelled} km!");
            _Engine = new Engine("selfrepair", _Engine.Power);
            Console.WriteLine("The engine is starting");
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
        }
    }
}
