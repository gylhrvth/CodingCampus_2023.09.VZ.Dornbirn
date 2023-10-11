using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week03
{
    internal class ArraysUebung
    {
        public static void Start() 
        {

            int[] original = Array(10);

            foreach (int element in original)
            {
                Console.WriteLine(element + " ");
            }
            
        }

        public static int[] Array(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;

        }
    }
    
}
