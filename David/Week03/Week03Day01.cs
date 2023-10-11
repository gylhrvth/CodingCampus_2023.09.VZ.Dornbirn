using System;
namespace David.Week03
{
    public class Week03Day01
    {
        public static void StartWeek03Day01()
        {
            /*
			Random rand = new Random();
			int[] arr = new int[10];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(-50, 50);
			}

			for (int i = 0; i < arr.Length; ++i)
			{
				Console.WriteLine("{0}. = {1}", i, arr[i]);
			}
			Console.WriteLine("===================");
			Console.WriteLine("[{0}]", string.Join(", ", arr));
			*/






            Console.WriteLine("Formater");
            int[] arr1 = CreateArrayAsc(6);
            Console.WriteLine("[{0}]", string.Join(", " , arr1));

            Console.WriteLine();
            Console.WriteLine("For Each");
            foreach(int index in arr1)
            {
                Console.Write(index + " ");
            }






            Console.WriteLine();
            int[] arr2 = CreateArrayDesc(5);
            PrintArray2(arr2);

            /*int[] arr3 = CreateArrayRandom(7);
            PrintArray(arr3);
            */

        }
        //--------------

        public static int[] CreateArrayAsc(int size)
        {
            int[] arr1 = new int[size];
            for (int e = 0; e < size; e++)
            {
                arr1[e] = e + 1;
            }
            return arr1;
            
        }
        



        //-----------

        public static int[] CreateArrayDesc(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr2[i] = -i - 1;
            }
            return arr2;
        }

        public static void PrintArray2(int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }
            Console.WriteLine();

        }


        //---------------
        /* public static int[] CreateArrayRandom(int size)
         {
             return null;
         }*/

    }






}


