using System;
using System.Collections;
using System.Xml.Linq;

namespace Eren.Week03
{
    public class ArrayExample
    {
        public static Random rand = new Random();

        public static void StartArrayExample()
        {




            //	int[] fixArray = {5, 3, 12, -4, 0, 9, 6, 2};
            //	int[] myArray = Create(10);

            //	Console.WriteLine("[{0}]", string.Join(", ", fixArray));
            //          Console.WriteLine("[{0}]", string.Join(", ", myArray));


            //	for (int i = 0; i < myArray.Length; i++)
            //	{
            //		int value = myArray[i];
            //		Console.WriteLine("myArray[{0}] = {1}", i, value);
            //	}

            //	foreach (int value in myArray)
            //	{
            //		Console.WriteLine("... {0}", value);
            //	}
            //      }

            //      public static int[] Create(int size)
            //{
            //	int[] arr = new int[size];
            //	for (int i = 0; i < arr.Length; i++)
            //	{
            //		arr[i] = rand.Next(100);
            //	}

            //	return arr;


            //int[] myArr = CreateArrays(7);
            //Console.WriteLine("[{0}]", string.Join(", ", myArr));

            //int[] myArr2 = CreateArraysDesc(12);
            //Console.WriteLine("[{0}]", string.Join(", ", myArr2));


            //PrintArray(myArr2);


            //Console.WriteLine("Original");
            //Console.WriteLine();
            //int[] original = Array(10);
            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //int[] copy = makeACopy(original);

            //Console.WriteLine("[{0}]", string.Join(", ", copy));

            //original[0] = 100;
            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", copy));
            //original[3] = 444;
            //Console.WriteLine("[{0}]", string.Join(", ", original));
            //Console.WriteLine("[{0}]", string.Join(", ", copy));




            //Console.WriteLine("Copy");
            //Console.WriteLine();

            //int[] Random = RandomNum(10);
            //Console.WriteLine("[{0}]", string.Join(", ", Random));


            //Foreach Schleife
            //foreach (int elemnent in Random)
            //{
            //    Console.Write(elemnent + " ");
            //}
            //For schleife
            //for (int i = 0; i < Random.Length; i++)
            //{
            //    Console.Write(Random[i] + " ");
            //}
            //Console.Write(Random[0] + " ");
            //Console.Write(Random[1] + " ");
            //Console.Write(Random[2] + " ");

            //for (int i = 0; i < Random.Length; i++)
            //{
            //    Console.Write(Random[i++] + " ");
            //}

            //int[] Random = RandomNumCrazy(10);


            //foreach (int elemnent in Random)
            //{
            //    Console.Write(elemnent + " ");
            //}

            //foreach (int elemnent in Random)
            //{
            //    Console.Write(elemnent + " ");
            //}


            //int[] arr = Array30(30);



            //foreach (int elemnent in arr)
            //{
            //    if (elemnent > 30)
            //    {
            //        Console.Write(elemnent + " ");
            //    }
            //}

            //int count = CountOver30(arr);
            //Console.WriteLine(count + " sind über 30");


            //int[] arr = RandomArray(10);



            //foreach (int element in arr)
            //{
            //    if (element > 30)
            //    {
            //        Console.Write(element + " ");
            //    }
            //}

            //foreach (int element in arr)
            //{
            //    int summe = 0;
            //    summe += element;
            //    Console.WriteLine("Summe ist " + summe);
            //}


            //}
            //public static int ArraySumme(int[] res)
            //{

            //    return;

            int[] arr = RandomArray(10);



            foreach (int element in arr)
            {
                if (element > 0)
                {
                    Console.Write(element + " ");
                }
            }

        }

        public static int[] RandomArray(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 100);
            }
            return Array;
        }

        //public static int ArraySumme(int[] size)
        //{


        //    foreach(int element in arr)
        //    {

        //    }
        //}


        //public static int[] RandomArray(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        Array[i] = rand.Next(0, 100);
        //    }
        //    return Array;
        //}






        //public static int[] Array30(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        Array[i] = rand.Next(0, 101);

        //    }
        //    return Array;
        //}
        //public static int CountOver30(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 30)
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}






        //public static int[] RandomNumCrazy(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    { //public static int[] RandomNumCrazy(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    { //public static int[] RandomNumCrazy(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    { //public static int[] RandomNumCrazy(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //public static int[] RandomNumCrazy(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        Array[i] = rand.Next(-50, 50);

        //    }


        //    return Array;

        //}


        //public static int[] RandomArray(int size)
        //{
        //    int[] Array = new int[size];
        //    for (int i = 0; i < Array.Length; i++)
        //    {
        //        Array[i] = rand.Next(0, 100);

        //    }


        //    return Array;

        //}



        ///////////////////////////////////////////


        //public static int[] randomNum()
        //{
        //    int Min = 0;
        //    int Max = 20;
        //    int[] test2 = new int[5];

        //    Random randNum = new Random();
        //    for (int i = 0; i < test2.Length; i++)
        //    {
        //        test2[i] = randNum.Next(Min, Max);
        //        Console.WriteLine(test2);

        //    }

        //}

        //public static int[] Array(int size)
        //{
        //    int[] arr = new int[size];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = i + 1;

        //    }
        //    return arr;
        //}

        //public static int[] makeACopy(int[] original)
        //{
        //    int[] copy = new int[original.Length];
        //    for (int i = 0; i < original.Length; i++)
        //    {
        //        copy[i] = original[i];
        //    }
        //    return copy;
        //}


        //public static int[] CreateArrays(int size)
        //{
        //    int[] result = new int[size];
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = 1 + i;
        //    }

        //    return result;
        //}



        //public static int[] CreateArraysDesc(int size)
        //{
        //    int[] result = new int[size];
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = size - i;
        //    }

        //    return result;
        //}


        //public static void PrintArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i]);
        //    }
        

    }

}

