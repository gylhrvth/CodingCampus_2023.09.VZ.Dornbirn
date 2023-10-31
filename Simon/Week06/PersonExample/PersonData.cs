using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.PersonExample
{
    public class PersonData
    {
        public static void Start()
        {
            Person p1 = new Person("Max", 11);
            Person p2 = new Person("Till", 34);

            Console.WriteLine(p1.Height);
            p1.Height = 1.84;
            p1.Weight = 84;
            p2.Height = 1.02;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Kurse k1 = new Kurse("Code FAST LEARN FAST", DateTime.Now, 500, 9700, p2);
            Console.WriteLine(k1);
        }
    }
}
