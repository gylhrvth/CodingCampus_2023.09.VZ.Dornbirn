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
            //    "Die zahl ist zu niedrig!", "Du hast gewonnen!!! DAS WAR DIE RICHTIGE ZAHL", "Wieso versuchst du etwas anderes als eine Zahl einzugeben? Verwende etwas logik! Versuchs mal mit was schlauerem!", "Anzahl der Versuche:");

            //Guessing game Erweitert mit Benutzereingaben
            //Console.WriteLine("Input parameters for Guessing Game");
            //Guessinggame(ReaduserinputString("schreibe eine Willkommensnachricht"),
            //    ReaduserinputString("user soll wissen in welchem Parameter er die Zahlen erraten soll"),
            //    ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu hoch ist"),
            //    ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu nieder ist"),
            //    ReaduserinputString("schreibe eine Siegesnachricht"),
            //    ReaduserinputString("schreibe eine fehlernachricht für ungültige eingaben"),
            //    ReaduserinputString("schreibe eine anchricht die sagen soll wie viele Versuche man gebraucht hat (danach wird die zahl ausgegeben)"));

            Console.WriteLine("Task - Menue");
            Menue("Bitte wählen Sie nun", "Falsche Eingabe bitte versuche es erneut", "Wie groß soll ", "Welches Zeichen soll verwendet werden?");

            //Console.WriteLine("Task - Taschenrechner");
            //Taschenrechner("Falsche eingabe versuche es erneut!", "Bitte gib die erste Zahl an, mit welcher gerechnet werden soll", "Bitte gib die zweite Zahl an, mit welcher gerechnet werden soll", "Wähle einen Rechenoperator aus");





        }

        //Aufgabe String einlesen
        public static String ReaduserinputString(String prompt)
        {
            Console.WriteLine(prompt);
            String input = Console.ReadLine();
            return input;
        }



        //Aufgabe Zahl einlesen
        public static int Readuserinputint(String promt, String error, int minNumber, int maxNumber)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    if (output < minNumber || output > maxNumber)
                    {
                        Console.WriteLine("{0} ist keine mögliche Auswahl zwischen {1} und {2}", output, minNumber, maxNumber);
                    }
                    else
                    {
                        return output;
                    }

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
            int winningnumber = random.Next(0, 100);
            int count = 1;
            while (true)
            {
                int output = Readuserinputint(promt2, error, 0, 100);
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

        //Aufgabe Menue neu
        public static void Menue(String askusernumber, String errormsg, String howbig, String askzeichen)
        {
            Console.WriteLine("Willkommen bei meinen Aufgaben!");
            Console.WriteLine("Was möchten Sie zeichnen?");
            Console.WriteLine("{0,-4}Christbaum\n{1,-4}Quader\n{2,-4}Rhombus\n", "1)", "2)", "3)");
            int userinput = Readuserinputint(askusernumber, errormsg, 1, 3);
            bool askinput = true;

            while (true)
            {
                while (true)
                {
                    if (userinput == 1)
                    {
                        Methoden___Schleifen.PrintChristmasTree(Readuserinputint(howbig + "Christbaum sein?", errormsg, 0, 1000), Readuserinputchar(askzeichen, errormsg));
                        break;
                    }
                    else if (userinput == 2)
                    {
                        Methoden___Schleifen.PrintEmptySquare(Readuserinputchar(askzeichen, errormsg), Readuserinputint(howbig + "Quader sein?", errormsg, 0, 1000));
                        break;
                    }
                    else if (userinput == 3)
                    {
                        Methoden___Schleifen.PrintRhombus(Readuserinputchar(askzeichen, errormsg), Readuserinputintonlynotsraight(howbig + "Rhombus sein? (verwende nur ungerade zahlen für eine schönes Bild)", errormsg));
                        break;
                    }
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
                        userinput = Readuserinputint(askusernumber, errormsg, 1, 3);
                        break;
                    }
                }
            }
        }

        //Aufgabe Menue old
        public static void Menue2(String askusernumber, String errormsg, String howbig, String askzeichen)
        {
            Console.WriteLine("Willkommen bei meinen Aufgaben!");
            Console.WriteLine("Was möchten Sie zeichnen?");
            Console.WriteLine("{0,-4}Christbaum\n{1,-4}Quader\n{2,-4}Rhombus\n", "1)", "2)", "3)");
            int userinput = Readuserinputint(askusernumber, errormsg, 1, 3);
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
                            Methoden___Schleifen.PrintChristmasTree(Readuserinputint(howbig + "Christbaum sein?", errormsg, 0, 1000), Readuserinputchar(askzeichen, errormsg));
                            askinput = false;
                        }
                        else if (userinput == 2)
                        {
                            Methoden___Schleifen.PrintEmptySquare(Readuserinputchar(askzeichen, errormsg), Readuserinputint(howbig + "Quader sein?", errormsg, 0, 1000));
                            askinput = false;
                        }
                        else if (userinput == 3)
                        {
                            Methoden___Schleifen.PrintRhombus(Readuserinputchar(askzeichen, errormsg), Readuserinputintonlynotsraight(howbig + "Rhombus sein? (verwende nur ungerade zahlen für eine schönes Bild)", errormsg));
                            askinput = false;
                        }
                        else if (userinput < 1 || userinput > 3)
                        {
                            userinput = Readuserinputint(askusernumber, errormsg, 1, 3);
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
                        userinput = Readuserinputint(askusernumber, errormsg, 1, 3);
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
        public static double Readuserinputdouble(String promt, String error, double minNumber, double maxNumber)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    double output = Convert.ToDouble(input);
                    if (output < minNumber || output > maxNumber)
                    {
                        Console.WriteLine("{0} ist leider zu groß bitte wähle nur Zahlen zwischen {1} und {2}", output, minNumber, maxNumber);
                    }
                    else
                    {
                        return output;
                    }

                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        public static double Calcuserinput(double userinput, double userinput2, char userinputoperator)
        {
            double result = 0;
            if (userinputoperator == '+')
            {
                result = userinput + userinput2;
            }
            if (userinputoperator == '-')
            {
                result = userinput - userinput2;
            }
            if (userinputoperator == '*')
            {
                result = userinput * userinput2;
            }
            if (userinputoperator == '^')
            {
                result = userinput;
                for (int i = 0; i < userinput2; i++)
                {
                    result *= userinput;
                }

            }
            if (userinputoperator == '/')
            {
                if (userinput2 == 0)
                {
                    Console.WriteLine("Eine Division durch 0 ist nicht möglich! Dies ist ein FATALER Fehler vielleicht lernst du indem das Programm jetzt abbricht und du neu starten musst!");
                    throw new DivideByZeroException();  //absicht dass das Programm abgebrochen wird
                }
                else
                {
                    result = userinput / userinput2; ;
                }
            }
            return result;
        }
        public static char Readuserinputmathchar(String chooseoperator, String error)
        {
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
                    userinputoperator = Readuserinputchar(" Wow du hast zwar einen String ausgewählt, jedoch ist dieser kein Rechenoperator DENK NACH!!!!!!", error);
                }
            }
            return userinputoperator;
        }
        public static double Readuserinputdoublecalc(String promt, String error, double minNumber, double maxNumber)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    if (input.Contains("."))
                    {
                        input = input.Replace('.', ',');
                    }
                    double output = Convert.ToDouble(input);
                    if (output < minNumber || output > maxNumber)
                    {
                        Console.WriteLine("{0} ist leider zu groß bitte wähle nur Zahlen zwischen {1} und {2}", output, minNumber, maxNumber);
                    }
                    else
                    {
                        return output;
                    }

                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }

        // Aufgabe: Taschenrechner var 1.0   . fixen zb. 10.2 == 10,2
        public static void Taschenrechner(String error, String number1, String number2, String chooseoperator)
        {
            Console.WriteLine("Willkommen beim Rechner ich kann für dich +,-,*,^ und / rechnen!");
            double result = 0;
            while (true)
            {
                double userinput = Readuserinputdoublecalc(number1, error, -10000000000000000, 10000000000000000);
                char userinputoperator = Readuserinputmathchar(chooseoperator, error);
                double userinput2 = Readuserinputdoublecalc(number2, error, -10000000000000000, 10000000000000000);

                result = Calcuserinput(userinput, userinput2, userinputoperator);
                Console.WriteLine("Ergebnis: {0}", result);
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
                        userinput = result;
                        userinputoperator = Readuserinputmathchar(chooseoperator, error);
                        userinput2 = Readuserinputdoublecalc("Bitte gib eine weithere Zahl ein mit welcher gerechnet werden soll", error, -10000000000000000, 10000000000000000);
                        Console.WriteLine("Zwischenergebnis: {0}", Calcuserinput(userinput, userinput2, userinputoperator));
                    }
                }
            }
        }

        // Aufgabe: Taschenrechner old
        public static void Taschenrechner2(String error, String number1, String number2, String chooseoperator)
        {
            Console.WriteLine("Willkommen beim Rechner ich kann für dich +,-,*,^ und / rechnen!");
            double result = 0;
            while (true)
            {
                double userinput = Readuserinputdouble(number1, error, int.MaxValue, int.MinValue);
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
                        userinputoperator = Readuserinputchar(" Wow du hast zwar einen String ausgewählt, jedoch ist dieser kein Rechenoperator DENK NACH!!!!!!", error);
                    }
                }
                double userinput2 = Readuserinputdouble(number2, error, int.MaxValue, int.MinValue);
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
                    if (userinput2 == 0)
                    {
                        Console.WriteLine("Eine Division durch 0 ist nicht möglich! Dies ist ein FATALER Fehler vielleicht lernst du indem das Programm jetzt abbricht und du neu starten musst!");
                        return;
                    }
                    else
                    {
                        Console.Write("Ergebnis: ");
                        result = userinput / userinput2;
                        Console.WriteLine(result);
                    }
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
                        userinput = result;
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
                        userinput2 = Readuserinputdouble("Bitte gib eine weithere Zahl ein mit welcher gerechnet werden soll", error, int.MaxValue, int.MinValue);
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
                            if (userinput2 == 0)
                            {
                                Console.WriteLine("Eine Division durch 0 ist nicht möglich! Dies ist ein FATALER Fehler vielleicht lernst du indem das Programm jetzt abbricht und du neu starten musst!");
                                return;
                            }
                            else
                            {
                                Console.Write("Ergebnis: ");
                                result = userinput / userinput2;
                                Console.WriteLine(result);
                            }
                        }
                    }
                }
            }
        }
        // catch wenn Zahl < 32 bit
        // userinput und userinput 2 verwechselt nach der Frage!!! und oberer code als methode schreiben damit ich ihn unten wieder verwenden kann

        // Aufgabe: Taschenrechner old v2
        public static void Taschenrechner3(String error, String number1, String number2, String chooseoperator)
        {
            Console.WriteLine("Willkommen beim Rechner ich kann für dich +,-,*,^ und / rechnen!");
            double result = 0;
            double memory = 0;
            while (true)
            {
                double userinput = Readuserinputdouble(number1, error, int.MaxValue, int.MinValue);
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
                double userinput2 = Readuserinputdouble(number2, error, int.MaxValue, int.MinValue);
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
                        if (userinput2 == 0)
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
                        userinput = Readuserinputdouble("Bitte gib eine weithere Zahl ein mit welcher gerechnet werden soll", error, int.MaxValue, int.MinValue);
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
