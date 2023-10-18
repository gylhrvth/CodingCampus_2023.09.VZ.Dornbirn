using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week04
{
    internal class Taschenrechner
    {


        public static void Start()
        {



            Taschenrechner1();
        }
        // damit ich Zeichen benutzen kann
        public static Char ReadChar(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    char myChar = Convert.ToChar(input);
                    return myChar;
                }
                catch
                {
                    Console.WriteLine("Falsch bitte gib +,-,*,/ oder ^ ein");
                }
            }

        }
        //umwandeln in eine Zahl
        public static float ReadFloat(string msg)
        {
            while (true)
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    float myNumber = Convert.ToSingle(input);
                    return myNumber;
                }
                catch
                {
                    Console.WriteLine("Das war keine Zahl");      
                }
        }

        public static void Taschenrechner1()
        {
            while (true)
            {

                float num1 = ReadFloat("Gib die erste Zahl ein:");
                char oprt = ReadChar("gib ein ob du addieren willst: +, subtrahieren willst -, multiplizieren willst *, dividieren willst /, oder hoch rechnen willst ^:");
                float num2 = ReadFloat("Gib die 2. Zahl ein:");
                float num2new = 1;
                

                if (oprt == '+')
                {
                    Console.WriteLine($"{num1}" + " + " + $"{num2}" + " = " + (num1 + num2));
                }
                else if (oprt == '-')
                {
                    Console.WriteLine($"{num1}" + " - " + $"{num2}" + " = " + (num1 - num2));
                }
                else if (oprt == '*')
                {
                    Console.WriteLine($"{num1}" + " * " + $"{num2}" + " = " + (num1 * num2));   
                }
                else if (oprt == '/')
                {
                    Console.WriteLine($"{num1}" + " / " + $"{num2}" + " = " + (num1 / num2));
                    float wahl = (num1 / num2);

                    if (wahl == 'j')
                    {
                        Console.WriteLine("gib die nächste Zahl ein" ,wahl + num2 );

                    }
                }
                else
                {
                    for (float i = 0; i < num2; i++)
                    {
                        num2new = num1 * num2new;
                    }
                    Console.WriteLine($"{num1}" + " ^ " + $"{num2}" + " = " + (num2new));
                }
            }



        }




    }
}
