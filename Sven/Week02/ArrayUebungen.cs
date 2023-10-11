using System;

namespace Sven.Week02
{
    public class ArrayUebungen
    {
        
        public static Random Random = new Random();
        
        public static void ArrayExamples()
        {
            Console.WriteLine("Example1 Count:");
            Count();
            Console.WriteLine();

            Console.WriteLine("RandomCount1");
            
            

            Console.WriteLine("Example2 Copy:");
            Copy();
            Console.WriteLine();

            Console.WriteLine("Example3 Random:");
            int[] arr = RandomArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            int count = RandomCount1(arr);
            Console.WriteLine("Es sind " +  count + " Zahlen über 30");


            /*
            Console.WriteLine("Example4 Range:");
            CrazyRange();
            Console.WriteLine();
            /*



            /*Console.WriteLine("Example4 Random Count:");
            RandomCount(0);
            Console.WriteLine();*/




        }
        

        static void Count()
        {
            int[] arr = {0,1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 , 10 };
            


            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }

            Console.WriteLine("=============================");


            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            

            for (int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
            }

        }
        

       static void Copy()
        {

            int[] arr = { 10, 23, 34, 12, 45, 16, 2 };
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            arr[2] = 0;

            int[] arr2 = arr;
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }


            /*
            int[] arr = { 6, 2, 8, 5, 4 };

            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);

            for (int i = 0; i < 10; i++)

                Console.WriteLine(String.Join(", ", copy));
            */

        }


       public static int[] RandomArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Next(101);

            }
            return arr;
            
        }


        static void CrazyRange()
        {

            for (int i = 0; i < 10; i++)
            {
                int[] arr = { Random.Next(-50, 50) };

                Console.WriteLine(String.Join(", ", arr));

            }

        }

        public static int RandomCount1(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if(i > 30)
                {
                    count++;
                }
            }
            return count;
        }


        /*
        static void RandomCount()
        {
            




            for ( int i = 0; i < 10; i++)
            {
                int[] arr1 = { Random.Next(1, 100) };


                    Console.WriteLine(String.Join(", ", arr1));
                if (arr1 > 30)
                {


                }
            }
            
           






                foreach (int element in arr)
            {
                arr1 = {Random.Next(1, 100)} ;

                if (arr > 30)

                Console.WriteLine(String.Join(", ", arr));


                
            }
        
        */

    }

}

