using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week06.ExerciseZoo
{
    internal class Animals
    {
        private string _Name;
        private string _Genus;
        private int _Age;

        public Animals(string name,int age, string genus)
        {
            _Name = name;
            _Age = age;
            _Genus = genus;
        }
  
        public void PrintZoo()
        {
            Console.WriteLine($"├── {_Name}, {_Genus}, {_Age}");
        }
    }
    
}
