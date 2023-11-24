using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.OOP
{
    internal class HouseSort : House
    {
        private List<Person> _Persons;
        private int _Door;

        public List<Person> Persons
        {
            get => _Persons; set => _Persons = value;
        }

        public HouseSort(int window, int door, string address, List<Person> persons) : base(door, window, address, persons)
        {
            _Persons = persons;

        }
        //public static void Sort(Person[] person)
        //{
        //    foreach (Person p in person)
        //    {
        //        for (int i = 0; i < p.Name.Length - 1; i++)
        //        {
        //            for (int j = 0; j < p.Name.Length - 1 - i; j++)
        //            {
        //                if (p.Name[j].CompareTo(p.Name[j + 1]) > 0)
        //                {
        //                    var temp = p.Name[j];
        //                    p.Name[j] = p.Name[j + 1];
        //                    p.Name[j + 1] = temp;
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine("Ascend by Alphabet:");
        //}

    }
}
