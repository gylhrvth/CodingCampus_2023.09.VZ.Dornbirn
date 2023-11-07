using Microsoft.VisualBasic;
using Sven.Week06.OOPPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPKurse
{
    internal class KurseEX
    {

        

        public static void Start()
        {
            Person p = new Person("McMahone", 99, 216, 89);
            KurseBasis k1 = new KurseBasis("Jonglier Kurs",new  DateTime(2023,09,26), 1200, 586, p );

            Console.WriteLine(k1);

        }

    }
}
