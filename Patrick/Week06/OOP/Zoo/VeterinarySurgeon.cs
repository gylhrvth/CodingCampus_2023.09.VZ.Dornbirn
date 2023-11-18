using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.OOP.Zoo
{
    internal class VeterinarySurgeon
    {
        private string _Name;


        public VeterinarySurgeon(string Name)
        {
            _Name = Name;
        }

        public string Name
        {
            get => _Name;
        }

        public void PrintDoctor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"   ├── Tierarzt: {Name}");
            Console.ResetColor();
        }

        public void HealAnimal()
        {
            Animal? lowestHPAnimal = null;


        }

    }
}
