using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dimitri.Week06._04Person2;

namespace Dimitri.Week06._04Person2
{
    internal class Person2Main
    {
        public static void Main()
        {
            Person2 p0 = new Person2(181, 24, "Dimitri", 80);

            Person2 p1 = new Person2(113, 10, "Dimitri", 25);

            Person2 p2 = new Person2(115, 12, "Dimitri", 27);

            Person2 p3 = new Person2(190, 18, "Dimitri", 98);

            List<Person2> personList = new List<Person2>() { p0, p1, p2, p3 };

            Person2.PrintMinMaxAvg(personList);
        }

    }
}
