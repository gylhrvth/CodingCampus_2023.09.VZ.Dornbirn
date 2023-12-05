using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class SortedHouseMain
    {
        public static void Start()
        {

            SortedHouse sorted1 = new SortedHouse(10, 11, "Bahnhofstrasse");
            SortedHouse sorted2 = new SortedHouse(3, 5, "Nibelungenstrasse");
            SortedHouse sorted3 = new SortedHouse(20, 10, "Millöckerstrasse");

            Person p1 = new Person("Robin", 27, Person.Genders.female);
            Person p2 = new Person("Santiago", 26, Person.Genders.female);
            Person p3 = new Person("Rosie", 22, Person.Genders.female);
            Person p4 = new Person("Kingston", 19, Person.Genders.male);
            Person p5 = new Person("Gabriela", 18, Person.Genders.female);
            Person p6 = new Person("Peyton", 23, Person.Genders.divers);
            Person p7 = new Person("Kaitlyn", 19, Person.Genders.female);
            Person p8 = new Person("Marlon", 18, Person.Genders.divers);
            Person p9 = new Person("Jacob", 17, Person.Genders.male);
            Person p10 = new Person("Antonella", 24, Person.Genders.female);


            sorted1.AddPerson(p1);
            sorted1.AddPerson(p2);
            sorted1.AddPerson(p3);
            sorted1.AddPerson(p4);

            sorted2.AddPerson(p5);
            sorted2.AddPerson(p6);
            sorted2.AddPerson(p7);

            sorted3.AddPerson(p8);
            sorted3.AddPerson(p9);
            sorted3.AddPerson(p10);


            Console.WriteLine("House1:\n" + sorted1.ToString());
            Console.WriteLine("House2:\n" + sorted2.ToString());
            Console.WriteLine("House3:\n" + sorted3.ToString());
        }
    }
}
