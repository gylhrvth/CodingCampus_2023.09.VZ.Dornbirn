using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week03
{
    internal class Arrays
    {
        public static void StartArrays()
        {
            //CreateArray(10);
            int[] a = CreateArray(5);
            int[] b = makeACopy(a);



            Console.Write("[{0}]", string.Join(",", a));
            Console.Write("[{0}]", string.Join(",", b));


            b[1] = 12331;


            Console.Write("[{0}]", string.Join(",", a));
            Console.WriteLine();
            Console.Write("[{0}]", string.Join(",", b));
            //CreateArray2(10);
            //RandomNumberArray();

            Console.WriteLine();

            Console.WriteLine("++++++");


            PrintArray(CreateArray(23));
            PrintArray(makeACopy(CreateArray(23)));

        }

        //Aufgabe: Number Array
        public static int[] CreateArray(int size)
        {
            int[] Numbers = new int[size];



            for (int i = 0; i < Numbers.Length; i++)
            {



                Numbers[i] = i;
              
            }

            
            return Numbers;
 

        }

        //Print Array

        public static void PrintArray(int[] name)
        {


            for (int i = 0;i < name.Length ;i++)
            {
                Console.WriteLine("{0}. = {1}", i + 1, name[i]);
            }
        }

        public static int[] CreateArray2(int size)
        {
            int[] Numbers = new int[size];
            int a = Numbers.Length;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = a;
                a--;
                
            }

        

            return Numbers;

        }

        //Aufgabe: Kopie

        public static int[] makeACopy(int[] original)
        {
            //Console.WriteLine(original[9]); //nimmt den ersten platz und zeigt welchen wert er hat


                int[] aaa = CreateArray(5);
                int[] bbb = aaa;



            return bbb;
        }

        //Aufgabe: Random Number Array

        public static void RandomNumberArray()
        {
            int[] Platz = new int[10];

            Random rand = new Random();

      

            for (int i = 0 ;i < Platz.Length ;i++)
            {
                int RandomNumber = rand.Next(100);

                Platz[i] = RandomNumber;

                Console.WriteLine(i + " = " + Platz[i]);
            }

            foreach (int stelle in Platz)
            {

                int RandomNumber = rand.Next(100);

                Platz[stelle] = RandomNumber;

                Console.WriteLine(stelle + " = " + Platz[stelle]); // stelle bei foreach ist immer 0

            }



            for (int i = 0; i < Platz.Length; i++)
            {

                int RandomNumber = rand.Next(100);

                Console.Write("[{0}]", string.Join("=", i, RandomNumber));

      

            }


            Console.WriteLine(Platz[2]);
            Console.WriteLine(Platz[5]);
            Console.WriteLine(Platz[10]);


        }

    }
}
