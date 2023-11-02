using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simon.Week02;

namespace Simon.Week06.Listen
{
    public class Listenerstellen
    {
        public static void Start()
        {
            



        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", string.Join(" ",arr[i]));
            }
        }



    }
}
