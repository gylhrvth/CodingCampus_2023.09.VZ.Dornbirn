using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week03
{
    internal class ExamplesArrays
    {
        public static void start()
        {
            /////////////////////////////////////////
            //createArrayIncrease(10);
            //Console.WriteLine("Increase");
            //printArray(createArrayIncrease(10));
            //Console.WriteLine("------------------");

            //Console.WriteLine("Decrease");
            //printArray(createArrayDecrease(10));
            //Console.WriteLine("------------------");
            //////////////////////////////////////////

            //makeACopy();
            RandomNumberArray(0, 100);
            RandomNumberArrayCrazyRange(-50, 50);
        }

        public static int[] createArrayIncrease(int count)
        {
            int[] array = new int[count];


            for (int x = 0; x < count; x++)
            {
                array[x] = x + 1;
                //Console.WriteLine(array[x]);
            }

            return array;
        }


        public static int[] createArrayDecrease(int count)
        {
            int[] array = new int[count];


            for (int x = 0; x < count; x++)
            {
                array[x] = count - x;
                // Console.WriteLine(array[x]);
            }


            return array;
        }


        public static void printArray(int[] array)
        {

            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));           //gyula syntax
        }

    //    public static int[] makeACopy(int[] originals)
    //    {
            

    //    }

        public static int[] RandomNumberArray(int low, int up)
        {
            int[] arrayRandom = new int[10];

            Random random = new Random();

            foreach (int x in arrayRandom)
            {
                arrayRandom[x] = random.Next(low, up);

                Console.Write("[{0}]", string.Join(", ", arrayRandom[x]));
            }

            Console.WriteLine();
            Console.WriteLine("------------------");

            for (int x = 0; x < 10; x++)
            {
                arrayRandom[x] = random.Next(low, up);

                Console.Write("[{0}]", string.Join(", ", arrayRandom[x]));
                //Console.Write(arrayRandom[1], arrayRandom[4], arrayRandom[9]);
            }
            //Console.WriteLine(arrayRandom[1], arrayRandom[4], arrayRandom[9]);
            Console.WriteLine();
            Console.WriteLine("------------------");

            return arrayRandom;
        }


        public static int[] RandomNumberArrayCrazyRange(int low, int up)
        {
            int[] arrayRandom = new int[10];

            Random random = new Random();

            foreach ( int x in arrayRandom)
            {
                arrayRandom[x] = random.Next(low, up);

                Console.Write("[{0}]", string.Join(", ", arrayRandom[x]));
            }
            return arrayRandom;
        }

    }
}
