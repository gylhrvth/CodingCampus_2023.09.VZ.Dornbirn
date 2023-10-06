using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week02
{
    internal class Arrays
    {
        public static void Start()
        {
            int[] arr = { 10, 12, 15, 66 };

            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            Console.WriteLine("===================");

            arr[0] = 100;
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
        }
    }
}
