using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class Pfleger
    {
        private string _Name;
        private int _Age;
        private string _Gender;

        public Pfleger(string name, int age, string gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public override string ToString()
        {
            return _Name; // Es wandelt zu einem String um
        }

        public string Name() { return _Name; }
        public string Gender() { return _Gender; }

        public void PrintPfleger()
        {
            Console.WriteLine($"  |-----Pfleger:{_Name}, {_Gender}");
        }

        public void FeedAnimal(Animal animal)
        {
            Console.WriteLine(animal.Name + " hatte Hunger und " + _Name + " hat ihm " + animal.lieblingsessen + " gegeben");
        }
    }
}
