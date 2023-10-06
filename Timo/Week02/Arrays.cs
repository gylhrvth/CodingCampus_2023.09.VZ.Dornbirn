using System;

namespace Timo.Week02
{
    public class Arrays
    {
        public static void Start()
        {
            //Aufgabe1.1: Number Array Aufwärts
            Console.WriteLine("\nNumber Array\r\n");
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
            Console.WriteLine("\nNumber Array\r\n");
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

            makeACopy(arrUp);

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
    }
}
