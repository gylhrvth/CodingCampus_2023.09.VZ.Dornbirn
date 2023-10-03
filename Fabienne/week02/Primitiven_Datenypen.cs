using System;
using System.Threading.Channels;

namespace Fabienne.week02
{
    public class Primitiven_Datentypen  
    {
        public static void StartPrimitivenDatentypen()
        {
            PrintSum();

            Faktorial();
        }

        public static void PrintSum()
        {
            for (int i = 20;  i <= 50; i++) 
            { 
                Console.WriteLine(i + i);
            }

            Console.WriteLine();
        }

        public static void Faktorial()
        {
            for (int i = 1; i <= 20; i++) 
            { 
                Console.WriteLine(i + i);
            }
        }

       
    }
}

