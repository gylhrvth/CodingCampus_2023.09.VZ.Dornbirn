using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week07._06Car
{
    public class CarMain
    {
        public static void Start()
        {
            Car c1 = new Car("The Fabian Company", "Fabian1",  new Tank("t1", 100), new Engine("e1", 100), 3000, Car.DriveType.Benzin);
            Car c2 = new Car("The Fabian Company", "BetterFabian1", new Tank("t2", 102), new Engine("e2", 200), 2500, Car.DriveType.Benzin);

            Console.WriteLine("{1} hat sein Ziel nach {0} km erreicht.", c1.Drive(2000), c1.Model);
            Console.WriteLine();
            Console.WriteLine("{1} hat sein Ziel nach {0} km erreicht.", c2.Drive(2000), c2.Model);
        }
    }
}
