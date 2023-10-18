using Jovo.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jovo.Week04
{
    internal class Menü_Input
    {

        public static void Start()
        {

            Menü("Bitte wähle zwischen 1-3","Falsch versuch es erneut", "wie groß soll es sein", "welches Zeichen soll ich verwenden", "Christbaum", "Quader", "Rhombus");

        }



        public static char Readuserinputchar(string prompt, String error)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    char output = Convert.ToChar(input);
                    return output;



                }
                catch
                {
                    Console.WriteLine(error);


                }
            }
        }

        public static int Readuserinputint(String promt, String error)
        {
            Console.WriteLine(promt);
            {
                while (true)
                {
                    try
                    {

                        String input = Console.ReadLine();
                        int output = Convert.ToInt32(input);
                        return output;

                    }
                    catch
                    {
                        Console.WriteLine(error);
                    }
                }

            }
        }








        public static void Menü(String askusernumber, String errormsg, String howbig, String askzeichen, String drawing1, String drawing2, String drawing3)
        {



            Console.WriteLine("Willkommen bei meinem Menü!");
            Console.WriteLine("Was möchten Sie zeichnen");
            Console.WriteLine("1 für Christbaum", drawing1);
            Console.WriteLine("2 für Quader", drawing2);
            Console.WriteLine("3 für Rhombus", drawing3);
            int userinput = Readuserinputint(askusernumber, errormsg);
            bool askinput = true;


            while(true)
            {

                try
                {

                    askinput = true;
                    while(askinput)
                    {

                        if (userinput == 1)
                        {
                            Methoden.PrintChristmasTree(Readuserinputint(howbig + "Christmastree?", errormsg), Readuserinputchar(askzeichen, errormsg));
                            askinput = false;

                        }
                        else if(userinput == 2)
                        {
                            Methoden.PrintTriangle4(Readuserinputint(howbig + "Quader?", errormsg), Readuserinputchar(askzeichen, errormsg));
                            askinput = false;
                        }
                        else if(userinput == 3)
                        {
                            Methoden.PrintMeinTest6(Readuserinputint(howbig + " Rhombus?", errormsg), Readuserinputchar(askzeichen, errormsg));
                            askinput = false;
                        }
                        else if(userinput < 1 || userinput > 3)
                        {
                            Console.WriteLine(errormsg);
                            userinput = Readuserinputint(askusernumber, errormsg);
                            askinput = false;
                        }
                    }
                    



                }
                catch
                {
                    Console.WriteLine(errormsg);
                }
                while (true)
                {
                    char ask = Readuserinputchar("Möchten Sie noch etwas zeichnen? (j/n)", errormsg);
                    if (ask == 'n')
                    {
                        return;
                    }
                    else if (ask == 'j')
                    {
                        Console.WriteLine("Was möchten Sie zeichnen?");
                        Console.WriteLine("{0,-4}Christbaum\n{1,-4}Quader\n{2,-4}Rhombus\n", "1)", "2)", "3)");
                        userinput = Readuserinputint(askusernumber, errormsg);
                        break;
                    }
                    else if (userinput == 1 || userinput == 2 || userinput == 3)
                    {
                        Console.WriteLine(errormsg);
                    }
                }


            }





        }

    }
}
