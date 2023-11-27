using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Selbsttest
{
    public class Person
    {
        private string _Name;
        private int _Age;
        private string _Gender;

        public Person(string name, int age, string gender)
        {
            _Name = name;
            _Age = age;
            _Gender = gender;
        }

        public void PrintStructure()
        {
            Console.WriteLine($"Name: {_Name} Alter: {_Age} Geschlecht: {_Gender}!");
        }


    }
}
