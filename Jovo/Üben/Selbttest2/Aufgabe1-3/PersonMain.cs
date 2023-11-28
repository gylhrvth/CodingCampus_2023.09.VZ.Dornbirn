using Jovo.Üben.Selbttest2.Aufgabe1_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbttest2.Aufgabe2
{
    internal class PersonMain
    {
        public static void Start()
        {
            Person p1 = new Person("Alice", 27, "female");
            Person p2 = new Person("Aanna", 26, "female");
            Person p3 = new Person("Aanika", 22, "female");
            Person p4 = new Person("Fabienne", 19, "female");
            Person p5 = new Person("Tina", 18, "female");
            Person p6 = new Person("Nina", 23, "female");
            Person p7 = new Person("Memo", 19, "male");
            Person p8 = new Person("Ali", 18, "male");
            Person p9 = new Person("Tim", 17, "male");
            Person p10 = new Person("David", 24, "male");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p7);
            Console.WriteLine(p8);
            Console.WriteLine(p9);
            Console.WriteLine(p10);



            
        }

        public static void Start2()
        {

            

            House h1 = new House(13, 11, "GuteFrageWo");
            House h2 = new House(17, 7, "WoDiese");
            House h3 = new House(55, 15, "GroßeWoDiese");

            Person p1 = new Person("Alice", 27, "female");
            Person p2 = new Person("Aanna", 26, "female");
            Person p3 = new Person("Aanika", 22, "female");
            Person p4 = new Person("Fabienne", 19, "female");
            Person p5 = new Person("Tina", 18, "female");
            Person p6 = new Person("Nina", 23, "female");
            Person p7 = new Person("Memo", 19, "male");
            Person p8 = new Person("Ali", 18, "male");
            Person p9 = new Person("Tim", 17, "male");
            Person p10 = new Person("David", 24, "male");

            h1.AddPerson(p1);
            h1.AddPerson(p2);
            h1.AddPerson(p3);

            h2.AddPerson(p4);
            h2.AddPerson(p5);
            h2.AddPerson(p6);
            h2.AddPerson(p7);

            h3.AddPerson(p8);
            h3.AddPerson(p9);
            h3.AddPerson(p10);

            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);
        }

        public static void Start3()
        {
            SortedHouse sorted1 = new SortedHouse(13, 11, "GuteFrageWo");
            SortedHouse sorted2 = new SortedHouse(17, 7, "WoDiese");
            SortedHouse sorted3 = new SortedHouse(55, 15, "GroßeWoDiese");

            Person p1 = new Person("Alice", 27, "female");
            Person p2 = new Person("Anna", 26, "female");
            Person p3 = new Person("Anika", 22, "female");
            Person p4 = new Person("Fabienne", 19, "female");
            Person p5 = new Person("Tina", 18, "female");
            Person p6 = new Person("Nina", 23, "female");
            Person p7 = new Person("Memo", 19, "male");
            Person p8 = new Person("David", 18, "male");
            Person p9 = new Person("Tim", 17, "male");
            Person p10 = new Person("Ali", 24, "male");


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
