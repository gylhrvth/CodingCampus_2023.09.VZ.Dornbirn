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
            Person p2 = new Person("Gyula", 44, 1.72, 85.0);


            Console.WriteLine(p);
            Console.WriteLine();
    
            p.Name = "Kerem";
            p2.Alter = 15;
            p2.Groeße = 1.80;
            p2.Gewicht = 65;

            Console.WriteLine(p);

        }
    }
}
