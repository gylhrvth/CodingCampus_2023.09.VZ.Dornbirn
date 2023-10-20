using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week03
{
    internal class NumberArray
    {
        public static void Start()
        {


            Console.WriteLine("Increase");
            int[] arr = Increase(10);
            foreach (int element in arr)
            {
                Console.WriteLine(element + ", ");
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));


            Console.WriteLine("Decrease");
            int[] arr2 = Decrease(10);
            foreach (int element in arr2)
            {
                Console.WriteLine(element +", ");
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr2));



            Console.WriteLine("MakeAKopie");
            int[] arr3 = MakeACopy(arr);
            foreach (int element in arr3)
            {
                Console.WriteLine(element + ", ");
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr3));

        }




        public static int[] Increase(int size)
        {

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1;

            }


            return arr;
        }



        public static int[] Decrease(int size)
        {

            int[] arr2 = new int[size];
            for (int i = 0;i < size; i++)
            {
                arr2[i] = size - i;

            }
            return arr2;
        }
        

        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }

        
    }
}
