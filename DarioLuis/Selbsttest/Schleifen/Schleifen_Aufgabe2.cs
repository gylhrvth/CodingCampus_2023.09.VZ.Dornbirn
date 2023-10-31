using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Schleifen
{
    public  class Schleifen_Aufgabe2
    {
        public static void Start()
        {
            int num = -31;
            for (int i = -11;i <= 30; i++) 
            {
                ++num;
                if (num % 3 == 0)
                {
                    Console.WriteLine(num++);
                }
            }
        }
    }
}
