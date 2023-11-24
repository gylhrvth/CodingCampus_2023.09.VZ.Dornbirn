using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week08._05Selftest.Person;

namespace Dimitri.Week08._05Selftest
{
    internal class Aufgabe1
    {
        public static Random rnd = new Random();
        public static void Main()
        {
            Person[] persons = new Person[10];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person("Name" + i, rnd.Next(1, 100), FindRandomGender());
            }

            

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }

    }
}
