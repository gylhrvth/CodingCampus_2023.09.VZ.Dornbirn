using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jovo.Week06._04Person2;

namespace Jovo.Week06._04Person2
{
    public class Person2Main
    {


        public static void Main()
        {
            List<Person2> personList = new List<Person2>() {
                new Person2("Mehmet", 23, 180, 83),
                new Person2("Jovo", 27, 183, 110),
                new Person2("Alihan", 25, 179, 80),
                new Person2("Gyula", 40, 177, 80),
                new Person2("Selina", 40, 177, 80),
                new Person2("Niklas", 40, 177, 80),
                new Person2("Sandro", 40, 177, 80),
                new Person2("Ömer", 40, 177, 80),
                new Person2("Gheorghe", 40, 177, 80)
        };




            Console.WriteLine("Alter:");
            Person2.PrintMinAge(personList);
            Person2.PrintMaxAge(personList);
            Person2.PrintAvgAge(personList);

            Console.WriteLine("Height:");
            Person2.PrintMaxheight(personList);
            Person2.PrintMinheight(personList);
            Person2.PrintAvgheight(personList);

            Console.WriteLine("Weigth:");
            Person2.PrintMaxweight(personList);
            Person2.PrintMinweight(personList);
            Person2.PrintAvgweight(personList);


            Console.WriteLine("[{0}]", string.Join(", ", personList));
            Person2.SortPeopleName(personList);
            Console.WriteLine("[{0}]", string.Join(", ", personList));

            Person2.SortPeopleWeight(personList);
            Console.WriteLine("[{0}]", string.Join(", ", personList));


        }

    }
}
