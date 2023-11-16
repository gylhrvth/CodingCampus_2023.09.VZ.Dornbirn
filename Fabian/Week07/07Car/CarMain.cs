using static Fabian.Selftest_SP.TowersOfHanoi;
using static Fabian.Week07._07Car.Car;

namespace Fabian.Week07._07Car
{
    public class CarMain
    {
        public static void Start()
        {
            Car c1 = new("The Fabian Company", "Fabian1", new Engine("engine1", 200), 3000, new Tank("tank1", 300), Car.CarDriveType.Benzin);
            SelfRepairingCar c2 = new("The Fabian Company", "Fabian2", new Engine("engine2", 250), 3300, new Tank("tank2", 300), Car.CarDriveType.Strom);
            AeroDynamicCar c3 = new("The Fabian Company", "Fabian3", new Engine("engine3", 250), 3300, new Tank("tank3", 300), Car.CarDriveType.Diesel);
            CrapCar c4 = new("The Fabian Company", "Fabian4", new Engine("engine4", 250), 3300, new Tank("tank4", 200), Car.CarDriveType.Gas);

            GasStation gs = new("Shell");
            RepairStation rs = new("Haueis");

            DriveMain(10000, c3, gs, rs);

        }

        public static void DriveMain(int distanceToDrive, Car car, GasStation gs, RepairStation rs)
        {
            if (car.GetType() == typeof(AeroDynamicCar)) car.Consumption /= 2;
            int start = distanceToDrive;
            Console.WriteLine("The engine is starting");
            SetConsoleColor(ConsoleColor.Green, "Brumm Brumm");
            while (distanceToDrive > 0)
            {
                int driven = car.Drive(distanceToDrive);
                distanceToDrive -= driven;
                if (distanceToDrive <= 0)
                {
                    string unit = (car.DriveType == CarDriveType.Strom) ? "kWh" : "L";
                    string type = (car.DriveType == CarDriveType.Strom) ? "battery" : "tank";
                    Console.WriteLine("{0} finished at {1} km with {2:N2}{3} left in the {4}\n", car.Model, start, car.Tank.Capacity, unit, type);
                    break;
                }
                if (car.Engine.IsBroken)
                {
                    if (car.GetType() == typeof(SelfRepairingCar)) car.SelfRepair();
                    else rs.ChangeEngine(car);
                }
                if (car.Tank.Capacity - car.Consumption < 0)
                    gs.FillTank(car, 50);

            }
        }
    }
}
