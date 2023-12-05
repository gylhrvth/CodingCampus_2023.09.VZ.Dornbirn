using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Selbsttest_OOP._1Person;

namespace Timo.Selbsttest_OOP._2Haus
{
    public class SortedHouse : Haus
    {
        public SortedHouse(int doors, int windows, string adress) : base(doors, windows, adress)
        { }
        public override void AddPerson(Person person)
        {
            Persons.Add(person);
            SortPersons();
        }

        public void SortPersons()
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                for (int j = 0; j < Persons.Count - i - 1; j++)
                {
                    if (Persons[j].Name.CompareTo(Persons[j + 1].Name) > 0)
                    {
                        Person temp = Persons[j + 1];
                        Persons[j + 1] = Persons[j];
                        Persons[j] = temp;
                    }
                }
            }
        }
    }
}
