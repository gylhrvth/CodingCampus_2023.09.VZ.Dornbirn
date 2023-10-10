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
            //RandomNumberArray(0, 101);
            //RandomNumberArrayCrazyRange(-50, 50);
            //randomNumberArrayZählen(0, 101);
            //randomNumberArraySumme(0, 101);
            randomNumberArrayMinMaxAvg(0, 101);
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

        //public static int[] makeACopy(int[] originals)
        //{
            

        //}


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

            }
            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", arrayRandom[1], arrayRandom[4], arrayRandom[9]));                                      //gib den 2. 5.und 9. Wert des Arrays aus
            Console.WriteLine("[{0}]", string.Join(", ", arrayRandom[1], arrayRandom[3], arrayRandom[5], arrayRandom[7], arrayRandom[9]));      // gib jeden 2. Wert des Arrays aus
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


        public static int[] randomNumberArrayZählen (int low, int up)
        {
            int[] randomNumber = new int[10];
            Random random = new Random();

            for( int x = 0; x < randomNumber.Length; x++)
            {
                randomNumber[x] = random.Next(low, up);

                if (randomNumber[x] >= 30)
                {
                    Console.Write("[{0}]", string.Join(", ", randomNumber[x]));
                }
                else
                {                   
                    Console.Write("XX");
                }
            }
            return randomNumber;
        }


        public static int[] randomNumberArraySumme (int low, int up)
        {
            int[] randomNumber = new int[10];
            Random random = new Random();
            int result = 0;

            for ( int x = 0; x < randomNumber.Length; x++)
            {
                randomNumber[x] = random.Next(low, up);
                result += randomNumber[x];

                Console.Write("[{0}]", string.Join(", ", randomNumber[x]));
            }
            Console.WriteLine();
            Console.WriteLine("Die Summe von den 10 Zahlen ist: " + result);

            return randomNumber;
        }


        public static int[] randomNumberArrayMinMaxAvg(int low, int up)
        {
            int[] randomNumber = new int[10];




            return randomNumber;
        }
 
    }
}
