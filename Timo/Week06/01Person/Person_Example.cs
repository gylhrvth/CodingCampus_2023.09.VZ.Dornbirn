using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._01Person
{
    public class Person_Example
    {
        public static void Start()
        {
            Person P1 = new Person(180, 55, "Günther", 120);
            Person P2 = new Person(157, 34, "Maria", 95);
            //Console.WriteLine(P1);
            //Console.WriteLine();
            //Console.WriteLine(P2);
            //P1.Height = -9;
            //Console.WriteLine();
            //Console.WriteLine(P1.Name);
            //P1.Age = -6;
            //Console.WriteLine(P1.Age);



            Person P3 = new Person(183, 61, "Oswald", 81);
            Person P4 = new Person(180, 58, "Hanna", 49);
            Person P5 = new Person(203, 19, "Christine", 76);
            Person P6 = new Person(109, 43, "Chantal", 85);
            Person P7 = new Person(180, 17, "Jürgen", 55);
            Person P8 = new Person(130, 54, "Gümthi", 100);

            List<Person> PersonList = new List<Person>() { P1, P2, P3, P4, P5, P6, P7, P8 };
            //Console.WriteLine("Größe Min: " + SmalestNumber(PersonList(0) +"cm");
            PrintList(PersonList);

            Console.WriteLine();

            Statistic statistic = MinMaxAvg.CalcStatistics(PersonList);
            Console.WriteLine(statistic);

            Console.WriteLine();

            PersonList = SortPersons(PersonList, Data.AGE);
            Console.WriteLine("Sorted persons:");
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");
            }
        }

        public static void PrintList(List<Person> list)
        {
            Console.WriteLine("{0}", string.Join("\n", list));
        }
        public enum Data
        {
            AGE, 
            HEIGHT,
            WEIGHT, 
            NAME
        }
        public static List<Person> SortPersons(List<Person> persons, Data data)
        {
            // p1 and p2 are variables and can be changed
            switch (data)
            {
                case Data.AGE:
                    persons.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
                    return persons;
                case Data.HEIGHT:
                    persons.Sort((p1, p2) => p1.Height.CompareTo(p2.Height));
                    return persons;
                case Data.WEIGHT:
                    persons.Sort((p1, p2) => p1.Weight.CompareTo(p2.Weight));
                    return persons;
                case Data.NAME:
                    persons.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal)); // CompareTo cant be used on strings
                    return persons;
                default:
                    return persons;
            }

        }
    }
}
