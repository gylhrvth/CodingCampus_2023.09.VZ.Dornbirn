using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week02
{
    internal class Primitive_Datentypen
    {
        public static void Start()
        {
            Console.WriteLine("SUM");
            int sum = AddprintSum(20, 50);
            Console.WriteLine(sum);
            Console.WriteLine("PRINTFACTORIAL");
            PrintFactorial(20);
            Console.WriteLine();

          
        }
        public static int AddprintSum(int minNum, int maxNum)
        {
             int sum = 0;
            
             for(int i = minNum; i <= maxNum; i++)
             {
                 sum += i;
                 
             }
            return sum;
            
            
        }
        public static void PrintFactorial(int maxNum)
        {
            for(int i = 1; i<= maxNum; i++)
            {
                Console.WriteLine("{0,2}! ={1,20}", i, CalcFactorial(i));
            }
        }


        public static long CalcFactorial(int maxNum)
        {
            long result = 1;
            for (int i = 1; i <= maxNum; i++)
            {
                result = result * i;
            }
            return result;
        }



    }
}
