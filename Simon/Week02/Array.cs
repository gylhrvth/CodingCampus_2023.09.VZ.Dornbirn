using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week02
{
    internal class Array
    {
        public static void Start()
        {
            //Aufgabe Number Array
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            Console.WriteLine();
            int[] arr2 = new int[10];
            int a = arr2.Length;
            for (int i= 0; i < arr2.Length; i++)
            {
                arr2[i] = a;
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
                a--;
            }
            Console.WriteLine("\nMake a Copy");
            MakeACopy(arr);
            Console.WriteLine();
            //Aufgabe Random Number Array
            Random random = new Random();
            int[] arr3 = new int[10];
            foreach ()
            {
                arr3[i] = random.Next(0, 100);
                Console.WriteLine("{0} = {1}", i, arr[i]);
            }



        }
        //Aufgabe Kopie
        public static int[] MakeACopy(int[] original)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(original[i]);
            }
            return original;
        }
       
        
    

    }
}
