using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.SelbstTestOOP
{
    public class Main
    {
        public static void Start()
        {
            House house1 = new House("Müller", "blau", "stein", "Herrenstr.50");
            House house2 = new House("Zack", "gelb", "stroh", "weizeneggerstr.5");
            House house3 = new House("indiens", "white", "beton", "hinterhuf. 30");

            Person person1 = new Person("martin", 24, "male");
            Person person2 = new Person("lukas", 33, "female");
            Person person3 = new Person("gyula", 66, "divers");
            Person person4 = new Person("sahra", 0, "divers");
            Person person5 = new Person("stefan", 3, "male");

            Person person6 = new Person("sabrine", 2423, "female");
            Person person7 = new Person("sandro", 333, "male");
            Person person8 = new Person("elias", 16, "female");
            Person person9 = new Person("erik", 9, "divers");
            Person person10 = new Person("fabian", 88, "male");

            //Console.WriteLine(person10.ToString());

            house1.AddPerson(person4);
            house1.AddPerson(person3);
            house1.AddPerson(person2);


            Console.WriteLine(house1.ToString());

        }

    }
}
