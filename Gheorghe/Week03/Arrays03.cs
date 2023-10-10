using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week03
{
    internal class Arrays03
    {
        public static void Start()
        {
            createArraysIncrease(10);
            createArraysDecrease(15);
            Randomnumber(100);
        }
        public static int[] createArraysIncrease(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);

            }
            return array;
        }

        public static int[] createArraysDecrease(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] =  size - i ;
                Console.WriteLine(array[i]);

            }
            return array;
        }

        public static int[] Randomnumber(int size)
        {
           ´  
            foreach (Size item in array)
            {
                Console.WriteLine(item);
            }
            return array.ToArray();

        }
    }

}





