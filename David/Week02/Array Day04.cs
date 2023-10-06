using System;
namespace David.Week02
{
    public class Array_Day04
    {
        public static void StartArray_Day04()
        {
            ArrayListe1();
            Console.WriteLine("----");

            ArrayListe2();
            Console.WriteLine("-----");


        }
        public static void ArrayListe1()
        {
            // von 0 - 10

            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            Console.WriteLine("----");


            // von 10 - 0

            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Console.WriteLine(arr2);
            for (int i2 = 0; i2 < arr2.Length; i2++)
            {
                Console.WriteLine("{0}. = {1}", i2, arr2[i2]);
            }
            Console.WriteLine("----");
        }

        // von 0 - 10 mit int Benutzerangabe

        public static void ArrayListe2()
        {
            int[] numbers = new int[10];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;

                Console.WriteLine("{0}. = {1}", i, numbers[i]);
            }
            
        }


}
}