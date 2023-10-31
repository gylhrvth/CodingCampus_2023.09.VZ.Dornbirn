using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Schleifen
{
    public class Schleifen_Aufgabe1
    {
        public static void Start()
        {
            int num = 10;
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(num--);
            }
        }
    }
}
