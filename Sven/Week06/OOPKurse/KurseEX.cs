﻿using Sven.Week06.OOPPerson;
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
            Person p = new Person("Barbie", 99, 216, 89);
            KurseBasis k1 = new KurseBasis("Jonglier Kurs", 128, 1200, 586, p );

            Console.WriteLine(k1);

        }

    }
}
