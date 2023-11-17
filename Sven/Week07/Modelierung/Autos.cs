using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week07.Modelierung
{
    internal class Autos
    {
        private string _ModellName;
        private string _Color;
        private int _HorsePower;

        public Autos(string name, string color, int hp) 
        {
            _ModellName = name;
            _Color = color;
            _HorsePower = hp;
        }

        //public static void PrintCar()
        //{
        //    Console.WriteLine($"Modell: {_ModellName}\nHorsepower: {_Horsepower}\nColor: {_Color}");

        //}


    }
}
