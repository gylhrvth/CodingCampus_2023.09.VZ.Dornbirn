using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Mehmet
{
    internal class PersonExamples
    { 

        public static void Start()
        {
            Person p1 = new Person (180,22,"Memo",81);
            Person p2 = new Person(185, 26, "Günther", 149);
            

            p1.Height = 151;
            p2.Age = 30;
            p1.Name = "MeMo";

            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);

            
        }


    }
}
