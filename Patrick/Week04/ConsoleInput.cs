using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week04
{
    internal class ConsoleInput
    {
        public static void start() 
        {
            //AUFGABE 1
            Console.WriteLine("Write the input: ");
            Console.WriteLine("The Inputstring = " + StringRead());
                                                                        //Lies mit Hilfe von .... ein String des Benutzers ein und gib diesen aus
        }

        public static string StringRead()
        {
            string Input = Console.ReadLine();
            return Input;
        }

        public static void StringWrite(string input) 
        {
            Console.WriteLine(input);
        }
    }
}
