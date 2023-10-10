using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week02
{
    internal class Array
    {
        public static void start()
        {
            Console.WriteLine("Aufgabe NumberArray ");
            int[] testArray = createArray(10);
        }
        public static int[] createArray(int size)
        {
            int[] arr = new int[size];
         
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);                              
            }
            return arr;
        }

 
    }
}
