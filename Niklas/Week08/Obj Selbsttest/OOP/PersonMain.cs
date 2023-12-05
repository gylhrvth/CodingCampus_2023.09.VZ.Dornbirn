using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Obj_Selbsttest.OOP
{
    internal class PersonMain
    {
        public static void Start()
        {
            List<Person> person = new List<Person>();

            person.Add(new Person("Günter", 43, Gender.male));
            person.Add(new Person("Hans", 45, Gender.male));
            person.Add(new Person("Jürgen", 32, Gender.male));
            person.Add(new Person("Lisa", 12, Gender.female));
            person.Add(new Person("Elisabeth", 59, Gender.female));
            person.Add(new Person("Heidi", 8, Gender.female));
            person.Add(new Person("Dwaine 'The Rock' Johnson", 51, Gender.diverse));
            person.Add(new Person("John", 17, Gender.male));
            person.Add(new Person("Ralph", 15, Gender.male));
            person.Add(new Person("Renate", 91, Gender.female));

            foreach (Person p in person)
            {
                Console.WriteLine(p);
            }
        }
    }
}
