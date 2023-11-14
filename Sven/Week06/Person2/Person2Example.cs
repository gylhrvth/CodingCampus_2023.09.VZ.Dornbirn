using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.Person2
{
    internal class Person2Example
    {
        public static void Start()
        {
            List<Person2> personList = new List<Person2>()
            {
                new Person2("Dome", 24, 176, 95),
                new Person2("Barbara", 50, 159, 68),
                new Person2("Eric", 21, 184, 115),
                new Person2("Sven", 24, 175, 70)
            };

            Person2.PrintMinMaxAvg(personList);

            Person2.SortAge(personList);

            Person2.SortWeight(personList);

            Person2.SortHeight(personList);

            Person2.PrintAvgweight(personList);

            Person2.PrintAvgage(personList);

            Person2.PrintAvgheight(personList);

            Person2.SortName(personList);
            Console.WriteLine("Name [{0}]", string.Join(", ", personList));



        }
    }
}
