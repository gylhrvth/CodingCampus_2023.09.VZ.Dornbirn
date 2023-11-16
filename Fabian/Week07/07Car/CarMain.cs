using System;

namespace Fabian.Week07._07Car
{
    public class CarMain
    {
        public static void Start()
        {
            Car c1 = new("The Fabian Company", "Fabian1", new Engine("engine1", 200), 3000, new Tank("tank1", 100), Car.CarDriveType.Benzin);
            Car c2 = new("The Fabian Company", "Fabian2", new Engine("engine1", 250), 3300, new Tank("tank2", 125), Car.CarDriveType.Diesel);

            Console.WriteLine("{0} finished at {1} km\n",c1.Model, c1.Drive(2000));
            Console.WriteLine("{0} finished at {1} km\n", c2.Model, c2.Drive(2000));
        }
    }
}
