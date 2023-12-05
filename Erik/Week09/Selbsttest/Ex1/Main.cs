using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week09.Selbsttest.Ex1
{
    internal class Main
    {
        private static List<Person> personList = new List<Person>();
        public static void Start()
        {
            Person person1 = new Person("Peter", 18, Person._Gender.male);
            Person person2 = new Person("Anne", 93, Person._Gender.female);
            Person person3 = new Person("Lisa", 42, Person._Gender.female);
            Person person4 = new Person("Sara", 52, Person._Gender.female);
            Person person5 = new Person("Susi", 18, Person._Gender.female);
            Person person6 = new Person("Tim", 44, Person._Gender.male);
            Person person7 = new Person("Sven", 13, Person._Gender.male);
            Person person8 = new Person("Katharina", 93, Person._Gender.female);
            Person person9 = new Person("Rosi", 15, Person._Gender.female);
            Person person10 = new Person("Sabine", 31, Person._Gender.female);

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
            personList.Add(person6);
            personList.Add(person7);
            personList.Add(person8);
            personList.Add(person9);
            personList.Add(person10);

            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }

        }

    }
}
