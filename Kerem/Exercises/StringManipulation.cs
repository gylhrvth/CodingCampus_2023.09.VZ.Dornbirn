using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class StringManipulation
    {
        public static void Start()
        {
            //define few variables
            int age = 23;
            string name = "Kerem";
            string job = "Developer";

            // 1. string concatenation(Verkettung)
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + "years old");

            // 2. string formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old", "I am a {2}", name, age, job);

            // 2. string interpolation
            // string interpolation uses $ at the start which will allow us to write our variabels like this (variableName)
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age}years old");

            // 4. verbatim strings
            //verbatim string start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"C:/User/Admin/Dog/Pictures/dog1/png");

            //with verbatim strings even valid escape characters won't work
            Console.WriteLine("This is \n a huge dogshit!");
            Console.WriteLine(@"This is \n a huge dogshit!");
        }
    }
}
