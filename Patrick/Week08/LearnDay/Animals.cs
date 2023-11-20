using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.LearnDay
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;
        private string _Gender;


        public Animals(string name, string genus, int age, string gender)
        {
            _Name = name;
            _Genus = genus;
            _Age = age;
            _Gender = gender;
        }
        public void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"│          ├── \"{_Name}\" ist das Tier \"{_Genus}\", ist \"{_Age}\" Jahre alt und ist \"{_Gender}\"");           
        }

        public override string ToString()
        {
            return _Name;
        }
    }
}
