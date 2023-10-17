using Simon.Week01;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Simon.Week03
{
    internal class Console_Input
    {
        public static Random random = new();
        public static void Start()
        {
            //Console.WriteLine("Task - Read a String");
            //String userinputstring = ReaduserinputString("Enter a String");
            //Console.WriteLine("Userinput was: " + userinputstring);

            //Console.WriteLine("\nTask - Read a Number");
            //int userinput = Readuserinputint("Enter a number", "Please only input numbers! Try again!");
            //Console.WriteLine("Userinput was: " + userinput);

            //Console.WriteLine("Task - Guessinggame");
            //Guessinggame("Willkommen beim super coolen Zahlen Ratespiel", "Errate die Zahl zwischen 0 und 100", "Die Zahl ist zu hoch!",
            //    "Die zahl ist zu niedrig!", "Du hast gewonnen!!! DAS WAR DIE RICHTIGE ZAHL", "Please only input numbers! Try again!", "Your number of guesses was:");
            //Guessing game Erweitert mit Benutzereingaben
            //Console.WriteLine("Input parameters for Guessing Game");
            //Guessinggame(ReaduserinputString("schreibe eine Willkommensnachricht"),
            //    ReaduserinputString("user soll wissen in welchem Parameter er die Zahlen erraten soll"),
            //    ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu hoch ist"),
            //    ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu nieder ist"),
            //    ReaduserinputString("schreibe eine Siegesnachricht"),
            //    ReaduserinputString("schreibe eine fehlernachricht für ungültige eingaben"),
            //    ReaduserinputString("schreibe eine anchricht die sagen soll wie viele Versuche man gebraucht hat (danach wird die zahl ausgegeben)"));

            //Console.WriteLine("Task - Menue");
            //Menue("Bitte wählen Sie nun", "Falsche Eingabe bitte versuche es erneut", "Wie groß soll ", "Welches Zeichen soll verwendet werden?");

            Console.WriteLine("Task - Taschenrechner");
            Taschenrechner("Falsche eingabe versuche es erneut!", "Bitte gib die erste Zahl an, mit welcher gerechnet werden soll", "Bitte gib die zweite Zahl an, mit welcher gerechnet werden soll", "Wähle einen Rechenoperator aus");





        }

        //Aufgabe String einlesen
        public static String ReaduserinputString(String prompt)
        {
            Console.WriteLine(prompt);
            String input = Console.ReadLine();
            return input;
        }



        //Aufgabe Zahl einlesen
        public static int Readuserinputint(String promt, String error)
        {
            Console.WriteLine(promt);
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

        //Aufgabe Ratespiel
        public static void Guessinggame(String promt1, String promt2, String hnumber, String lnumber, String won, String error, String numberofguesses)
        {
            Console.WriteLine(promt1);
            int winningnumber = random.Next(0, 5);
            int count = 1;
            while (true)
            {
                try
                {
                    int output = Readuserinputint(promt2, error);
                    if (output > winningnumber)
                    {
                        Console.WriteLine(hnumber);
                    }
                    else if (output < winningnumber)
                    {
                        Console.WriteLine(lnumber);
                    }
                    else
                    {
                        Console.WriteLine(won);
                        Console.WriteLine(numberofguesses + " " + count);
                        return;
                    }
                    count++;
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        //für Menue
        public static char Readuserinputchar(String prompt, String error)
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
        public static int Readuserinputintonlynotsraight(String promt, String error)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    if (output % 2 == 1)
                    {
                        return output;
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }

                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }

        //Aufgabe Menue
        public static void Menue(String askusernumber, String errormsg, String howbig, String askzeichen)
        {
            Console.WriteLine("Willkommen bei meinen Aufgaben!");
            Console.WriteLine("Was möchten Sie zeichnen?");
            Console.WriteLine("{0,-4}Christbaum\n{1,-4}Quader\n{2,-4}Rhombus\n", "1)", "2)", "3)");
            int userinput = Readuserinputint(askusernumber, errormsg);
            bool askinput = true;


            while (true)
            {
                try
                {
                    askinput = true;

                    while (askinput)
                    {
                        if (userinput == 1)
                        {
                            Methoden___Schleifen.PrintChristmasTree(Readuserinputint(howbig + "Christbaum sein?", errormsg), Readuserinputchar(askzeichen, errormsg));
                            askinput = false;
                        }
                        else if (userinput == 2)
                        {
                            Methoden___Schleifen.PrintEmptySquare(Readuserinputchar(askzeichen, errormsg), Readuserinputint(howbig + "Quader sein?", errormsg));
                            askinput = false;
                        }
                        else if (userinput == 3)
                        {
                            Methoden___Schleifen.PrintRhombus(Readuserinputchar(askzeichen, errormsg), Readuserinputintonlynotsraight(howbig + "Rhombus sein? (verwende nur ungerade zahlen für eine schönes Bild)", errormsg));
                            askinput = false;
                        }
                        else if (userinput < 1 || userinput > 3)
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
        //Methoden für Taschenerchner
        public static double Readuserinputlong(String promt, String error)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    double output = Convert.ToDouble(input);
                    return output;
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        // Aufgabe: Taschenrechner
        public static void Taschenrechner(String error, String number1, String number2, String chooseoperator)
        {
            Console.WriteLine("Willkommen beim Rechner ich kann für dich +,-,*,^ und / rechnen!");
            double result = 0;
            double memory = 0;
            while (true)
            {
                double userinput = Readuserinputlong(number1, error);
                char userinputoperator = Readuserinputchar(chooseoperator, error);
                while (true)
                {
                    if (userinputoperator == '+' || userinputoperator == '-' || userinputoperator == '*' || userinputoperator == '^' || userinputoperator == '/')
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(error);
                        userinputoperator = Readuserinputchar("", error);
                    }
                }
                double userinput2 = Readuserinputlong(number2, error);
                try
                {
                    if (userinputoperator == '+')
                    {
                        Console.Write("Ergebnis: ");
                        result = userinput + userinput2;
                        Console.WriteLine(result);
                    }
                    if (userinputoperator == '-')
                    {
                        Console.Write("Ergebnis: ");
                        result = userinput - userinput2;
                        Console.WriteLine(result);
                    }
                    if (userinputoperator == '*')
                    {
                        Console.Write("Ergebnis: ");
                        result = userinput * userinput2;
                        Console.WriteLine(result);
                    }
                    if (userinputoperator == '^')
                    {

                        for (int i = 0; i < userinput2; i++)
                        {
                            Console.Write("Ergebnis: ");
                            result = userinput * userinput;
                            Console.WriteLine(result);
                        }
                    }
                    if (userinputoperator == '/')
                    {
                        if(userinput2 == 0)
                        {
                            Console.WriteLine("Eine Division durch 0 ist nicht möglich!");
                            
                        }
                        else
                        {
                            Console.Write("Ergebnis: ");
                            result = userinput / userinput2;
                            Console.WriteLine(result);
                        }
                    }
                    //Console.WriteLine(result);
                }
                catch
                {
                    Console.WriteLine(error);
                }
                while (true)
                {
                    char ask = Readuserinputchar("Möchten Sie noch etwas rechnen? (j/n) Oder weiterrechnen? (w)", error);
                    if (ask == 'n')
                    {
                        return;
                    }
                    else if (ask == 'j')
                    {
                        break;
                    }
                    else if (ask == 'w')
                    {
                        userinput2 = result;
                        userinputoperator = Readuserinputchar(chooseoperator, error);
                        while (true)
                        {
                            if (userinputoperator == '+' || userinputoperator == '-' || userinputoperator == '*' || userinputoperator == '^' || userinputoperator == '/')
                            {
                                break;
                            }
                            else
                            {
                                Console.Write(error);
                                userinputoperator = Readuserinputchar("", error);
                            }
                        }
                        userinput = Readuserinputlong("Bitte gib eine weithere Zahl ein mit welcher gerechnet werden soll", error);
                        try
                        {
                            if (userinputoperator == '+')
                            {
                                Console.Write("Zwischenergebnis: ");
                                result = userinput + userinput2;
                                Console.WriteLine(result);
                            }
                            if (userinputoperator == '-')
                            {
                                Console.Write("Zwischenergebnis: ");
                                result = userinput - userinput2;
                                Console.WriteLine(result);
                            }
                            if (userinputoperator == '*')
                            {
                                Console.Write("Zwischenergebnis: ");
                                result = userinput * userinput2;
                                Console.WriteLine(result);
                            }
                            if (userinputoperator == '^')
                            {

                                for (int i = 0; i < userinput2; i++)
                                {
                                    Console.Write("Zwischenergebnis: ");
                                    result = userinput * userinput;
                                    Console.WriteLine(result);
                                }
                            }
                            if (userinputoperator == '/')
                            {
                                if (userinput2 == 0)
                                {
                                    Console.WriteLine("Eine Division durch 0 ist nicht möglich!");

                                }
                                else
                                {
                                    Console.Write("Zwischenergebnis: ");
                                    result = userinput / userinput2;
                                    Console.WriteLine(result);
                                }
                            }
                            //Console.WriteLine(result);
                        }
                        catch
                        {
                            Console.WriteLine(error);
                        }
                    }
                }
            }
            // beim weiterrechnen durch 0 bricht programm nicht ab


        }
    }

}
