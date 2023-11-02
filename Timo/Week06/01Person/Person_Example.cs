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
            Person P1 = new Person(1.80, 55, "Günther", 120);
            Person P2 = new Person(1.57, 34, "Maria", 95);
            Console.WriteLine(P1);
            Console.WriteLine();
            Console.WriteLine(P2);
            P1.Height = -9;

            //Console.WriteLine();
            //Console.WriteLine(P1.Name);
            //P1.Age = -6;
            //Console.WriteLine(P1.Age);
        }

    }
}
