using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week03
{
    public class ArrayLists
    {

        public static void StartArrayLists()
        {

            CreateArray(10);
            Console.WriteLine("---------------------------");
            CreateArray2(10);


        }

        public static void CreateArray(int size)
        {
            int[] arr01 = new int[size];

            for (int i= 0; i < arr01.Length; i++)
            {
                arr01[i] = i;
                Console.WriteLine("{0}: {0}" ,i);
            }
        }

        public static void CreateArray2(int size)
        {
            int[] arry02 = new int[size];

            for (int i = size; i > 0; i--)
            {
                arry02[i - 1] = size;
                Console.WriteLine("{0} : {0}", i);
            }
        }
    }
}
