using System;

namespace Timo.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            //Aufgabe1.1: Number Array Aufwärts
            Console.WriteLine("\nNumber1.1 Array\r\n");
            int[] arrUp = new int[10];
            for (int i = 0; i < arrUp.Length; i++)
            {
                arrUp[i] = i+1;
            }
            for (int i = 0; i < arrUp.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arrUp[i]);
            }

            //Aufgabe1.1: Number Array Abwärts
            Console.WriteLine("\nNumber1.2 Array\r\n");
            int[] arrDown = new int[10];
            int a = arrDown.Length;
            for (int i = 0; i < arrDown.Length; i++)
            {
                arrDown[i] = a ;
                a--;
            }
            for (int i = 0; i < arrDown.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arrDown[i]);
            }

            //Aufgabe2
            Console.WriteLine("\nNumber2 Kopie\r\n");
            makeACopy(arrUp);


            //Aufgabe3
            Console.WriteLine("\nNumber2 Kopie\r\n");
            Random random = new Random();
            
            int[]arr = new int[10];
            foreach (int number in arr)
            {
                int randomNumber = random.Next(1,100);
                arr[number] = randomNumber;
                Console.WriteLine($"{arr[number]} ");
            }
        }

        //Aufgabe2: Kopie
        public static int[] makeACopy(int[] original)
        {
            for (int i= 0;i<original.Length; i++) 
            { 
                Console.WriteLine(original[i]);
            }
            return original;
        }

        public static int[] Random(int i, int min, int max);
    }
}
