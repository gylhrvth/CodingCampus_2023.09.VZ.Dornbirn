using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class VoidMethods
    {
        public static void Start()
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and called from a method");
        }
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string text)
        {
            Console.WriteLine(text);
        }
    }
}
