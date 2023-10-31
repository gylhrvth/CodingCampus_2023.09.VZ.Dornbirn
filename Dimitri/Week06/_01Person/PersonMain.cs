using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week06._01Person
{
    public class PersonMain
    {
        public static void Main()
        {
            Person p = new Person(174, 31, "Dimitri", 64);

            Console.WriteLine(p);
        }
    }
}
