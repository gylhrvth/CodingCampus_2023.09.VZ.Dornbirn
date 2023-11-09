using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.CarSimulation
{
    internal class CarExample
    {
        public static void Start()
        {
            Car nissanSkyline = new Car("Nissan", "Skyline", 200, 60, 800);
            Car peugeot202 = new Car("Peugeot", "202", 30, 40, 780);
            Car renaultDauphine = new Car("Renault", "Dauphine", 37, 40, 800);

            double km = 0;

            Drive(nissanSkyline, km);
        }
        public static void Drive(double km)
        {
            Car Skyline = new Car("Nissan", "Skyline", 200, 60, 800);

            double fultank = Skyline.Tankinhalt;

            for (; Skyline.Tankinhalt > 1; Skyline.Tankinhalt--)
            {
                Console.WriteLine("Driving!");
                km++;
                Skyline.Tankinhalt -= 0.11;
            }
            if (Skyline.Tankinhalt <= 1)
            {
                Console.WriteLine("\nTank leer!\n");
                for (; Skyline.Tankinhalt < fultank - (fultank * 0.2); Skyline.Tankinhalt++)
                {
                    Console.Write("Auto wird getankt... \n");
                }
                if (Skyline.Tankinhalt % 1 != 0)
                {
                    Skyline.Tankinhalt -= 0.1;
                }
            }
            Console.WriteLine("\nDroven kilometers: " + km * 10);


        }
    }
}
