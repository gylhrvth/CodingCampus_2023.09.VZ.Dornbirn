using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Zählen
    {
        public static void Start()

        {
            double d = 0.1;
            Console.WriteLine("d = " + d);
            for (int i = 0; i <= 100; i++)

            {
                d = 0.1 + d;
                Console.WriteLine("d = " + Math.Round(d, 1));
            }

        }

    }
}

