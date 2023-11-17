using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week06.Person
{
    public class PersonExample
    {
        public static void Start()
        {
            Person2 p1 = new Person2("Ali", 83, 22, 176);
            Person2 p2 = new Person2("Johan", 33, 33, 333);

            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Countweight);
            //Console.WriteLine(p1.CountAge);
            //Console.WriteLine(p1.CountHeight);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());





        }
    }
}



