using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week06.NmsPerson
{
    internal class PersonMain
    {
        public static void Start()
        {
            Person p = new Person("Cemal", 20, 1.73, 83.2);

            Console.WriteLine(p);
            Console.WriteLine();

            p.Name = "Arda";
            p.Alter = 15;
            p.Groeße = 1.80;
            p.Gewicht = 65;

            Console.WriteLine(p);

        }
    }
}
