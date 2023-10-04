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
            Console.WriteLine("Sum");
            printSum(20, 50);
            Console.WriteLine();
        }
        public static void printSum(int minNum, int maxNum)
        {
             int sum = 0;
            
             for(int i = minNum; i <= maxNum; i++)
             {
                 sum = sum + i;
             }
                
            
            Console.Write(sum);
        }
        public static void printFactorial(int)
    }
}
