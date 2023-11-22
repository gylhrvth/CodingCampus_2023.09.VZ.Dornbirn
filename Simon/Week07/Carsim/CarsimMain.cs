using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.Carsim
{
    internal class CarsimMain
    {
        public static void Start()
        {

            Car car1 = new Car("VW", "Golf", 80, 50, Car.Fuel.Diesel, 750);
            Car car2 = new Car("Speed", "FastCAR", 800, 130, Car.Fuel.Diesel, 1100);

            car1.Printcarsim(1000);
            car2.Printcarsim(1000);

        }
    }
}
