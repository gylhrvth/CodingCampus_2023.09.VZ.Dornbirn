using Mehmet.Week06.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.SelbstTest
{
    public class Main
    {
        public static void Aufgabe1_MainStart()
        {
            Person person1 = new Person("Bababuja",44,"Male");
            Person person2 = new Person("Bazinga", 332, "Female");
            Person person3 = new Person("Roberto", 23, "FeMale");
            Person person4 = new Person("Pablo", 31, "Male");
            Person person5 = new Person("Adam", 40, "Male");
            Person person6 = new Person("Kowalski", 19, "Male");
            Person person7 = new Person("Sanchez", 21, "Male");
            Person person8 = new Person("BieneMaja", 200, "Female");
            Person person9 = new Person("Löwe", 33, "Female");
            Person person10 = new Person("MrKrabs", 64, "Male");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("----Personen----"); Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(person1); Console.WriteLine(person2); Console.WriteLine(person3); Console.WriteLine(person4); Console.WriteLine(person5);
            Console.WriteLine(person6); Console.WriteLine(person7); Console.WriteLine(person8); Console.WriteLine(person9); Console.WriteLine(person10);
            
           
        }
        public static void Aufgabe2_MainStart()
        {
            Person person1 = new Person("Bababuja", 44, "Male");
            Person person2 = new Person("Bazinga", 332, "Female");
            Person person3 = new Person("Roberto", 23, "FeMale");
            Person person4 = new Person("Pablo", 31, "Male");
            Person person5 = new Person("Adam", 40, "Male");
            Person person6 = new Person("Kowalski", 19, "Male");
            Person person7 = new Person("Sanchez", 21, "Male");
            Person person8 = new Person("BieneMaja", 200, "Female");
            Person person9 = new Person("Löwe", 33, "Female");
            Person person10 = new Person("MrKrabs", 64, "Male");

            House house1 = new House("MilchStrasse", 2, 7);
            House house2 = new House("LangenStrasse", 1, 4);
            House house3 = new House("KeineStrasse", 3, 90);

            house1.AddPerson(person1);house2.AddPerson(person2);house3.AddPerson(person3);
            house1.AddPerson(person4); house2.AddPerson(person5); house3.AddPerson(person6);
            house1.AddPerson(person7); house2.AddPerson(person8); house3.AddPerson(person9);
            house1.AddPerson(person10);

            Console.WriteLine(house1);
            house1.PrintPersonFromList(); Console.WriteLine("==============");
            Console.WriteLine(house2); 
            house2.PrintPersonFromList(); Console.WriteLine("==============");
            Console.WriteLine(house3);
            house3.PrintPersonFromList(); Console.WriteLine("==============");


        }

        public static void Aufgabe3_MainStart()
        {
            Person person1 = new Person("Bababuja", 44, "Male");
            Person person2 = new Person("Bazinga", 332, "Female");
            Person person3 = new Person("Roberto", 23, "FeMale");
            Person person4 = new Person("Pablo", 31, "Male");
            Person person5 = new Person("Adam", 40, "Male");
            Person person6 = new Person("Kowalski", 19, "Male");
            Person person7 = new Person("Sanchez", 21, "Male");
            Person person8 = new Person("BieneMaja", 200, "Female");
            Person person9 = new Person("Löwe", 33, "Female");
            Person person10 = new Person("MrKrabs", 64, "Male");

            SortedHouse sortedHouse1 = new SortedHouse("MilchStrasse", 2, 7);
            SortedHouse sortedHouse2 = new SortedHouse("LangenStrasse", 1, 4);
            SortedHouse sortedHouse3 = new SortedHouse("KeineStrasse", 3, 90);


            sortedHouse1.AddPerson(person1); sortedHouse2.AddPerson(person2); sortedHouse3.AddPerson(person3);
            sortedHouse1.AddPerson(person4); sortedHouse2.AddPerson(person5); sortedHouse3.AddPerson(person6);
            sortedHouse1.AddPerson(person7); sortedHouse2.AddPerson(person8); sortedHouse3.AddPerson(person9);
            sortedHouse1.AddPerson(person10);

            Console.WriteLine(sortedHouse1);
            sortedHouse1.PrintPersonFromList(); Console.WriteLine("==============");
            Console.WriteLine(sortedHouse2);
            sortedHouse2.PrintPersonFromList(); Console.WriteLine("==============");
            Console.WriteLine(sortedHouse3);
            sortedHouse3.PrintPersonFromList(); Console.WriteLine("==============");


        }

    }
}
