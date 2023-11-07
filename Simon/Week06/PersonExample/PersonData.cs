using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.PersonExample
{
    public class PersonData
    {
        public enum Sort
        {
            Groesse,
            Alter,
            Gewicht,
            Name
        }
        public static void Start()
        {
            List<Person> listpersons = new List<Person>()
            {
                new Person("Max", 11, 1.98, 105.8),
                new Person("Till", 34, 1.65, 65),
                new Person("Muxel", 56, 1.46, 80.5),
                new Person("Tom", 20, 1.75, 65)
            };

            Person p1 = new Person("Max", 11, 1.98, 105.8);
            Person p2 = new Person("Till", 34, 1.65, 65);

            Console.WriteLine(p1);
            p1.Height = 1.84;
            p1.Weight = 84;
            p2.Height = 1.02;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Kurse k1 = new Kurse("Code FAST LEARN FAST", DateTime.Now, 500, 9700, p2);
            Console.WriteLine(k1);
            Calc calc = CalcStatsPersons.CalcStatsofPersons(listpersons);
            Console.WriteLine(calc);

            Sortlist(listpersons, Sort.Name);

            foreach (Person person in listpersons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");
            }
        }

        

        public static void Sortlist(List<Person> list, Sort sortby)
        {
            switch(sortby)
            {
                case Sort.Groesse:
                    list.Sort((d1, d2) => d1.Age.CompareTo(d2.Age));
                    break;
                case Sort.Alter:
                    list.Sort((d1, d2) => d1.Height.CompareTo(d2.Height));
                    break;
                case Sort.Gewicht:
                    list.Sort((d1, d2) => d1.Weight.CompareTo(d2.Weight));
                    break;
                case Sort.Name:
                    list.Sort((d1, d2) => d1.Name.CompareTo(d2.Name));
                    break;
            }
        }

    }
}
