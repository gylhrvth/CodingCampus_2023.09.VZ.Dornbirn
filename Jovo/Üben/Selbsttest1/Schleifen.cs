using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbsttest1
{
    internal class Schleifen
    {
        public static void Start()
        {
            Console.WriteLine("Schleifen Aufgabe 1");
            Schleifen1(10);
            Console.WriteLine("======================");

            Console.WriteLine("Schleifen Aufgabe 2");
            Schleifen2(-30, 30);
            Console.WriteLine("======================");


            Console.WriteLine("Schleifen Aufgabe 3");
            Schleifen3(10, 5);
            Console.WriteLine("======================");



        }


        //Schleifen Aufgabe 1
        public static void Schleifen1(int length)
        {
            for (int i = length; i > 0; i--)
            {

                Console.WriteLine(i);
            }

        }



        //Schleifen Aufgabe 2

        public static void Schleifen2(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }


        }


        public static void Schleifen3(int endMax, int endLow)
        {
            int result = 0;

            while (result <= endMax)
            {
                if (result <= endLow)
                {
                    Console.WriteLine(result);
                    result++;
                }
                else
                {
                    Console.WriteLine("{0}\n", result);
                    result++;
                }

            }


        }




    }
}
