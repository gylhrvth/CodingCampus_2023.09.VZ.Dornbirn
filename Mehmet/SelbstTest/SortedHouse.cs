
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mehmet.SelbstTest
{
    public  class SortedHouse : House
    {
        List<Person> personList = new List<Person>();
        //List<Person> temp = new List<Person>();

        public SortedHouse (string adress,int doors,int windows) : base (adress,doors,windows)
        {

        }

        public void PrintPersonFromList()
        {
            Console.WriteLine("---- Personen ----");
            foreach (Person person in personList)
            {
                Console.WriteLine(person);
            }
        }


        public override void AddPerson(Person person)
        {
              personList.Add(person);
            for (int i = 0; i < personList.Count - 1; i++)
            {
                for (int j = 0; j < personList.Count - 1; j++)
                {
                     Person person1 = personList[j];
                    Person person2 = personList[j + 1];

                    if (string.Compare(person1.Name, person2.Name) > 0)
                    {
                        personList[j] = person2;
                        personList[j + 1] = person;
                    }
                }
            }

        }


    }
}
