using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Schleifen
{
    public class Schleifen_Aufgabe3
    {
        public static void Start()
        {
            int num = -1;
            while (num <= 9)
            {
                num++;
                if (num > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(num);

                }else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
