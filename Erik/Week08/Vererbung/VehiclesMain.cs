using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week08.Vererbung
{
    public class VehiclesMain
    {
        public static void Start()
        {
            List<Vehicles> vehicles = new List<Vehicles>();

            vehicles.Add(new Vehicles("Porsche", 4, 100, true, 380));
            vehicles.Add(new Motobike("Yamaha", 2, 80, true, true, 200, 180));
            vehicles.Add(new Vehicles("Audi", 3, 200, false, 1000));
            PrintFinal(vehicles);
        }

        public static void PrintFinal(List<Vehicles> vehicles)
        {
            foreach (Vehicles element in vehicles)
            {
                element.PrintVehicle();
                Console.WriteLine();
            }

        }
    }
    
}
