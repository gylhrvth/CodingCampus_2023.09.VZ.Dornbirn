using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.OOP
{
    internal class HouseMain
    {
        public static void Start()
        {
            List<House> houses = new List<House>();
            List<Person> persons = new List<Person>();

            houses.Add(new House(2, 8, "Höchsterstraße 5", persons));
            houses.Add(new House(3, 12, "Fortnitestraße 69", persons));

            persons.Add(new Person("Hans", 45, Gender.male));
            persons.Add(new Person("Jürgen", 32, Gender.male));
            persons.Add(new Person("Lisa", 12, Gender.female));
            persons.Add(new Person("Elisabeth", 59, Gender.female));
            persons.Add(new Person("Heidi", 8, Gender.female));
            persons.Add(new Person("Dwaine 'The Rock' Johnson", 51, Gender.diverse));
            persons.Add(new Person("John", 17, Gender.male));
            persons.Add(new Person("Ralph", 15, Gender.male));
            persons.Add(new Person("Renate", 91, Gender.female));

            foreach (House house in houses)
            {
                Console.Write(house + " ");
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.Name);
                }
            }
        }
    }
}
