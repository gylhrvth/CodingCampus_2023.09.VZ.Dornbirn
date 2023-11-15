using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPPerson
{
    internal class Personexample
    {
        public static void Start()
        {
            Person p1 = new Person(133, 142, "The Rock", 586 );
                        

            Console.WriteLine(p1);
            Console.WriteLine(p1.Name);

        }
    }
}
