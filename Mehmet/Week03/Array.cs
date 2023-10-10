using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mehmet.Week03
{
    internal class Array
    {
        public static void start()
        {
            Console.WriteLine("Aufgabe: NumberArray");
            int[] arr = createArray(10);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Aufgabe: Kopie");
            int[] arr2 = makeACopy(7);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Aufgabe: Random Number Array");
            int rand = new Random().Next(100) + 1;

            int[] arr3 = RandomNumberArray(rand);


        }
        public static int[] createArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = i + 1;
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            for (int i2 = 0; i2 < arr.Length; i2++)
            {
                arr[i2] = size - i2;
                Console.WriteLine("{0}. = {1}", i2, arr[i2]);
            }
            return arr;
        }


        public static int[] makeACopy(int size)
        {
            int[] arr2 = new int[size];
            createArray(size);
            return arr2;
        }

        public static int[] RandomNumberArray(int x)
        {
            int[] arr3 = new int[x];
            if (x > 30)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x+30);
            }
            return arr3;
        }
    }
}
