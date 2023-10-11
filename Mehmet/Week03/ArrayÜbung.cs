using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mehmet.Week03
{
    internal class ArrayÜbung
    {


        public static Random rand = new Random();

        public static void start()
        {

            Console.WriteLine("Original");
            int[] original = Array(10);
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("OriginalR");
            int[] originalR = ArrayR(10);
            foreach (int element in originalR)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("Copy");
            int[] copy = MakeACopy(original);
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");



            Console.WriteLine("OriginalVerändert");
            original[4] = 34;
            original[2] = 71;
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();




            Console.WriteLine("RandomNumberArray");
            int[] arr = RandomNumberArray(10);
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");


            Console.WriteLine("RandomNumberArray2");
            int[] randArr = RandomNumberArray2(10);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));


            Console.WriteLine("RandomNumberArray jeden 2ten");
            for (int i = 0; i < randArr.Length; i += 2)
            {
                Console.Write(randArr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine(" 2: index = " + randArr[1]);
            Console.WriteLine(" 5: index = " + randArr[4]);
            Console.WriteLine("10: index = " + randArr[9]);
            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine();


            Console.WriteLine("RandomNumberArrayCrazyRange");
            int[] CrazyArr = RandomNumberArrayCrazyRange(10, -50, 50);
            foreach (int element in CrazyArr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");


            Console.WriteLine("RandomNumberArrayZählen");
            int Count30 = RandomNumberArrayZählen(CrazyArr);
            Console.WriteLine("[{0}]", string.Join(", ", CrazyArr));


            Console.WriteLine("Zahlen über 30: " + Count30);
            Console.WriteLine("----------------------------");


            Console.WriteLine("RandomNumberArraySumme");
            int Summe = RandomNumberArraySumme(randArr);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));
            Console.WriteLine("Summe = " + Summe);
            Console.WriteLine("----------------------------");


            Console.WriteLine("RandomNumberArrayMinMaxAvg");

            randArr = new int[]{ 2, 3};

            int Min = ArrayMin(randArr);
            int Max = ArrayMax(randArr);
            double Avg = ArrayAvg(randArr);
            Console.WriteLine("[{0}]", string.Join(", ", randArr));
            Console.WriteLine("Min = {0} Max = {1} Avg = {2}", Min, Max, Avg);
            Console.WriteLine("----------------------------");


            Console.WriteLine("BubblesortMitZahlen");
            int Ascending = BubblesortMitZahlenAscending(randArr);
            Console.WriteLine(Ascending);



        }


        public static int[] Array(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }


        public static int[] ArrayR(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }


        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }


        public static int[] RandomNumberArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            return arr;
        }


        public static int[] RandomNumberArray2(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(100);
            }
            return arr2;
        }


        public static int[] RandomNumberArrayCrazyRange(int size, int num1, int num2)
        {
            int[] CrazyArr = new int[size];
            for (int i = 0; i < CrazyArr.Length; i++)
            {
                CrazyArr[i] = rand.Next(num1, num2);
            }
            return CrazyArr;
        }


        public static int RandomNumberArrayZählen(int[] arr)
        {
            int Count30 = 0;
            foreach (int element in arr)
            {
                if (element > 30)
                {
                    Count30++;
                }
            }
            return Count30;
        }


        public static int RandomNumberArraySumme(int[] arr)
        {
            int Summe = 0;
            foreach (int element in arr)
            {
                Summe += element;
            }
            return Summe;
        }


        public static double ArrayAvg(int[] arr)
        {
            double Avg = 0;
            double Summe = 0;
            foreach (double element in arr)
            {
                Summe += element;
            }
            Avg = Summe / arr.Length;
            return Avg;
        }


        public static int ArrayMax(int[] arr)
        {
            int Max = Int32.MinValue;
            foreach (int element in arr)
            {
                if (element > Max)
                {
                    Max = element;
                }
            }
            return Max;
        }


        public static int ArrayMin(int[] arr)
        {
            int Min = Int32.MaxValue;
            foreach (int element in arr)
            {
                if (element < Min)
                {
                    Min = element;
                }
            }
            return Min;
        }


        public static int BubblesortMitZahlenAscending(int[] arr)
        {



            int Max = 0;
            
            foreach (int element in arr)
            {
                if (element > Max)
                {
                    Max = element;
                    return Max;
                }
                
            }



            return Max;


        }






    }
}

