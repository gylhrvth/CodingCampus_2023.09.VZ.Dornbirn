using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest
{
    internal class Arrays
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            Console.WriteLine(FirstAndLast(arr));
            Console.WriteLine(FirstAndLast(arr2));
            Console.WriteLine(FirstAndLast(arr3));
        }

        public static string FirstAndLast(int[] arr)
        {
            return "First: " + arr[0] + ", Last: " + arr[arr.Length - 1];
        }



    }
}
