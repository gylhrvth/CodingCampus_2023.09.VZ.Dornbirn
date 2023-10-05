using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week02
{
    internal class primitive_Datentypen
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 1");
            int sum = printSum(20, 50);
            Console.WriteLine(sum);

            Console.WriteLine("Aufgabe 2");
            PrintFactorial(20);
            Console.WriteLine();

          
        }
        public static int printSum(int min, int max)
        {
            int sum = 0;

            for (int i = min; i <= max; i++)
            {
                sum = sum + i;
            }
                return  sum;


        }
        public static void PrintFactorial(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.WriteLine("{0,2}! ={1,20}", i, printFact(i));
            }
        }



        public static long printFact(int max)
        {
            long sum = 1;
            for (int i = 1; i <= max; i++)
            {
                sum = sum * i;
                
            }
            
            return sum;
            
        }



    }   
    

    
}
