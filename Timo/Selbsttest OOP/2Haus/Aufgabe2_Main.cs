using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Selbsttest_OOP._1Person;

namespace Timo.Selbsttest_OOP._2Haus
{
    public class Aufgabe2_Main
    {
        public static void Start()
        {
            Haus H1 = new(14, 26, "Hauptstraße 1");
            H1.AddPerson(new("Günther", 53, Gender.male));
            H1.AddPerson(new("Sabine", 119, Gender.female));
            Haus H2 = new(21, 12, "Hauptstraße 2");
            H2.AddPerson(new("Stefan", 27, Gender.male));
            H2.AddPerson(new("Veronika", 89, Gender.female));
            Haus H3 = new(17, 27, "Hauptstraße 3");
            H3.AddPerson(new("Daria", 18, Gender.divers));
            H3.AddPerson(new("Günther2", 53, Gender.male));

            SortedHouse H4 = new(0,0,"Straße1") ;
            H4.AddPerson(new("Günther2", 53, Gender.male));
            H4.AddPerson(new("Daria", 18, Gender.divers));
            


            Console.WriteLine(H1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(H2.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(H3.ToString());
            Console.WriteLine("\n");
            Console.WriteLine(H4.ToString());
        }
    }
}
