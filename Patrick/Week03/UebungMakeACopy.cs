using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week03
{
    internal class UebungMakeACopy
    {
        public static void start()
        {
            int[] array = createArray(10);
            Console.WriteLine("Array mit aufsteigenden Zahlen");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");


            int[] arrayCopy = makeACopy(array);
            Console.WriteLine("Erstelle eine Kopie vom 1. Array");
            foreach(int i in arrayCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");


            array[0] = 200;
            Console.WriteLine("Den Arraywert an der 1. Stelle abgeändert");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Kopiertes Array nach der Änderung des Originals");
            foreach(int i in arrayCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
        }

        public static int[] createArray(int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < count; x++)
            {
                array[x] = x + 1;
                //Console.Write(array[x] + " ");
            }            
            return array;
        }

        public static int[] makeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            
            for(int x = 0;x < original.Length; x++)
            {
                copy[x] = original[x];
               //Console.WriteLine(copy[x]);
            }

            return copy;
        }


    }
}
