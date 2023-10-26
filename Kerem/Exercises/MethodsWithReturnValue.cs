using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class MethodsWithReturnValue
    {
        public static void Start()
        {
            Console.WriteLine(Devide(25,13));
            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Devide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
