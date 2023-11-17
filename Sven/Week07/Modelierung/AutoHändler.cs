using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Modelierung
{
    internal class AutoHändler
    {
        public static void Start()
        {
            Autos a = new Autos("Hyundai i30n", "Red", 280);

            
        }
        public static void PrintCar()
        {
            Console.WriteLine("Modell: {_ModellName}\nHorsepower: {_Horsepower}\nColor: {_Color}");

        }

    }
}
