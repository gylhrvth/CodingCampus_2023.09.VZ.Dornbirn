using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class Loops
    {     
        public static void Start()
        {
            Excersise1(0);

            Console.WriteLine("====================");
            Excersise2(30);

            Console.WriteLine("====================");
            Excersise3(10);
        }
        public static void Excersise1(int size)
        {
            for (int i = 10; i >= size; i--)
            {
                Console.Write(i + " ");
            }
        }
        public static void Excersise2(int size)
        {
            for(int i = -30; i <= size; i++)
            {
                   if( i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Excersise3(int size)
        {
            int i = 0;
            while (i <= size)
            {

                if( i > 6)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine(i++);
            }
           
            
        

            
         

        }




    }
}
