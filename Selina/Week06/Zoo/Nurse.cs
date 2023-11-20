using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.Zoo
{
    public class Nurse
    {
        private string _Name;
        private int _Age;
        private string _Gender;
        private string _FavoriteAnimal;
   

        public string Name { get => _Name; }
        public string FavoriteAnimal { get => _FavoriteAnimal; }
        public Nurse(string name, int age, string gender,string favoriteAnimalSpecies)
        {
            this._Name = name;
            this._Age = age;
            this._Gender = gender;
            this._FavoriteAnimal = favoriteAnimalSpecies;
        }

        //Nurse wird ausgegeben
        public void PrintZoo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"|           |-- {_Name}, {_Gender}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        //wird zu einem String gemacht
        public override string ToString()
        {
            return $"{_Name}";
        }
    }
}
