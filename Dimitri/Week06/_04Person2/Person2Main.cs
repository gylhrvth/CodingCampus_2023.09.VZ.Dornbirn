using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dimitri.Week06._04Person2;
using Dimitri.Week06._01Person;
using static Dimitri.Week06._03List.List;

namespace Dimitri.Week06._04Person2
{
    internal class Person2Main
    {
        public static void Main()
        {
            Person p0 = new Person(181, 24, "Bimitri", 80);

            Person p1 = new Person(113, 10, "aimitri", 25);

            Person p2 = new Person(115, 12, "Damitra", 27);

            Person p3 = new Person(190, 18, "damitra", 98);

            List<Person> personList = new List<Person>() { p0, p1, p2, p3 };

            //Console.WriteLine("Weight statistics:");
            //Console.WriteLine("Person mit dem minimalen Gewicht ist: {0}", PersonStatistics.MinWeight(personList).Name);
            //Console.WriteLine("Person mit dem maximalen Gewicht ist: {0}", PersonStatistics.MaxWeight(personList).Name);
            //Console.WriteLine("Das durchschnittliche Gewicht ist: {0} kg", PersonStatistics.AvgWeight(personList));
            //Console.WriteLine();
            //Console.WriteLine("Height statistics:");
            //Console.WriteLine("Person mit dem minimalen Höhe ist: {0}", PersonStatistics.MinHeight(personList).Name);
            //Console.WriteLine("Person mit dem maximalen Höhe ist: {0}", PersonStatistics.MaxHeight(personList).Name);
            //Console.WriteLine("Das durchschnittliche Höhe ist: {0} cm", PersonStatistics.AvgHeight(personList));
            //Console.WriteLine();
            //Console.WriteLine("Age statistics:");
            //Console.WriteLine("Person mit dem minimalen Alter ist: {0}", PersonStatistics.MinAge(personList).Name);
            //Console.WriteLine("Person mit dem maximalen Alter ist: {0}", PersonStatistics.MaxAge(personList).Name);
            //Console.WriteLine("Das durchschnittliche Alter ist: {0} Jahre", PersonStatistics.AvgAge(personList));

            PersonStatistics.ListToString(personList, "Unsorted List:");

            PersonStatistics.ListToString(PersonStatistics.Sort(personList, 0), "List sorted by Age:");

            PersonStatistics.ListToString(PersonStatistics.Sort(personList, PersonStatistics.SortingValues.Height), "List sorted by Height:");

            PersonStatistics.ListToString(PersonStatistics.Sort(personList, PersonStatistics.SortingValues.Weight), "List sorted by Weight:");

            PersonStatistics.ListToString(PersonStatistics.Sort(personList, PersonStatistics.SortingValues.Name), "List sorted by Name:");
        }
    }
}

