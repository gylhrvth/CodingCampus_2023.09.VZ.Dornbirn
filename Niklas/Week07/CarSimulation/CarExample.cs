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

            double km = 263;

            Drive(km);
        }
        public static void Drive(double km)
        {
            double km2 = km;
            double km3 = km;

            Car Skyline = new Car("Nissan", "Skyline", 200, 60, 800);
            Car peugeot202 = new Car("Peugeot", "202", 30, 40, 780);
            Car renaultDauphine = new Car("Renault", "Dauphine", 37, 40, 800);

            while (Skyline.Tankinhalt > 1 || km == 0)
            {
                km--;
                Skyline.Tankinhalt--;
                Skyline.Tankinhalt -= 0.11;
            }
            if (Skyline.Tankinhalt < 0.1 || km == 0)
            {
                Console.WriteLine("\nFuel empty or route finished!");
                Console.WriteLine($"Tankinhalt {Skyline.Tankinhalt:N1} ");
                Console.WriteLine($"{Skyline.Modell} droven kilometers: " + km * 10);
                //Fuel(Skyline.Tankinhalt, peugeot202.Tankinhalt, renaultDauphine.Tankinhalt);
            }

            while (peugeot202.Tankinhalt > 1 || km2 == 0)
            {
                km2--;
                peugeot202.Tankinhalt--;
                peugeot202.Tankinhalt -= 0.08;
            }
            if (peugeot202.Tankinhalt < 0.1 || km2 == 0)
            {
                Console.WriteLine("\nFuel empty or route finished!");
                Console.WriteLine($"Tankinhalt {peugeot202.Tankinhalt:N1} ");
                Console.WriteLine($"{peugeot202.Modell} droven kilometers: " + km2 * 10);
                //Fuel(peugeot202.Tankinhalt, peugeot202.Tankinhalt, Skyline.Tankinhalt);
            }

            while (renaultDauphine.Tankinhalt > 1 || km3 == 0)
            {
                km3--;
                renaultDauphine.Tankinhalt--;
                renaultDauphine.Tankinhalt -= 0.09;
            }
            if (Skyline.Tankinhalt < 0.1 || km3 == 0)
            {
                Console.WriteLine("\nFuel empty or route finished!");
                Console.WriteLine($"Tankinhalt {Skyline.Tankinhalt:N1} ");
                Console.WriteLine($"{renaultDauphine.Modell} droven kilometers: " + km3 * 10);
                Fuel(renaultDauphine.Tankinhalt, peugeot202.Tankinhalt, Skyline.Tankinhalt);
            }

        }
        public static void Fuel(double tankinhalt, double tankinhalt2, double tankinhalt3)
        {
            Car skyline = new Car("Nissan", "Skyline", 200, 60, 800);
            Car peugeot202 = new Car("Peugeot", "202", 30, 40, 780);
            Car renaultDauphine = new Car("Renault", "Dauphine", 37, 40, 800);
            double fulltank = skyline.Tankinhalt;
            double fulltank2 = peugeot202.Tankinhalt;
            double fulltank3 = renaultDauphine.Tankinhalt;

            while (tankinhalt < fulltank - (fulltank * 0.1))
            {
                tankinhalt++;
            }
            if (tankinhalt >= fulltank - (fulltank * 0.1))
            {
                Console.WriteLine($"\nTank of {skyline.Modell} full!");
            }

            while (tankinhalt2 < fulltank2 - (fulltank2 * 0.1))
            {
                tankinhalt2++;
            }
            if (tankinhalt2 >= fulltank2 - (fulltank2 * 0.1))
            {
                Console.WriteLine($"\nTank of {peugeot202.Modell}  full!");
            }

            while (tankinhalt3 < fulltank3 - (fulltank3 * 0.1))
            {
                tankinhalt3++;
            }
            if (tankinhalt3 >= fulltank3 - (fulltank3 * 0.1))
            {
                Console.WriteLine($"\nTank of {renaultDauphine.Modell} full!");
            }


        }
    }
}
