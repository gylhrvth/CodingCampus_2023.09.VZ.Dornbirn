using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.SelbsttestOOP
{
    internal class HouseMain
    {
        public static void Start()
        {
            House h1 = new House(10, 11, "Bahnhofstrasse");
            House h2 = new House(3, 5, "Nibelungenstrasse");
            House h3 = new House(20, 10, "Millöckerstrasse");

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

            h1.AddPerson(p1);
            h1.AddPerson(p2);
            h1.AddPerson(p3);

            h2.AddPerson(p4);
            h2.AddPerson(p5);
            h2.AddPerson(p6);

            h3.AddPerson(p7);
            h3.AddPerson(p8);
            h3.AddPerson(p9);
            h3.AddPerson(p10);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);


        }
    }
}
