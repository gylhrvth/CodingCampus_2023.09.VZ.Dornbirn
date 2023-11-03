using System;
using System.Runtime.Intrinsics.X86;

namespace David.Week06.PersonExample
{
    public class PersonExample
    {
        public static void Start()
        {
            Person p1 = new Person("David", "35", 45);
            Person p2 = new Person("Gyula", "40", 48);

            Console.WriteLine(p1.Gewicht);
            p1.Gewicht = "80";
            p1.Groesse = 170;
            p2.Gewicht = "70";
            p2.Schuhgroesse = 45;
            Console.WriteLine();

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);


        }
    }
}

