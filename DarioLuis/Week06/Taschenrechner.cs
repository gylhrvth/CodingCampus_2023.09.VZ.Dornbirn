namespace DarioLuis.Week06
{
    public class Taschenrechner
    {
        public static void Start()
        {
            bool f = true;

            Console.WriteLine("Das ist der persöhnliche Taschenrechner von Dario!!!");

            while (f == true)
            {
                //Erste Zahl
                Console.WriteLine("Gib deine erste Zahl ein: ");
                int a = Convert.ToInt32(Console.ReadLine());

                //Zeichen
                Console.WriteLine("Gib dein gewünschtes Zeichen ein (+,-,*,/): ");
                char b = Convert.ToChar(Console.ReadLine());

                //Zweite Zahl
                Console.WriteLine("Gib deine zweite Zahl ein: ");
                int c = Convert.ToInt32(Console.ReadLine());



                if (b == '+')
                {
                    long erg = a + c;
                    Console.WriteLine(a + " + " + c + " = " + erg);
                }
                if (b == '-')
                {
                    long erg = a - c;
                    Console.WriteLine(a + " - " + c + " = " + erg);
                }




                if (b == '*')
                {
                    long erg = a * c;
                    Console.WriteLine(a + " * " + c + " = " + erg);
                }
                try
                {
                    if (b == '/')
                    {


                        if (c == 0)
                        {
                            Console.WriteLine("Seit wann dividiert man durch null?");
                        }
                        long erg = a / c;
                        Console.WriteLine(a + " / " + c + " = " + erg);
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Diviedier durch Null auf die Zahl {0} ist nicht möglich!", a);
                }


                Console.WriteLine("Magst du nochmal rechnen? (Y/N)");
                string ans = Console.ReadLine();

                if (ans == "Y" || ans == "y" || ans == "yes" || ans == "Yes" || ans == "YES" || ans == "Yeah" || ans == "YEAH")
                {
                    f = true;
                }
                else if (ans == "N" || ans == "n" || ans == "no" || ans == "No" || ans == "NO" || ans == "Nah" || ans == "NAH")
                {
                    Console.WriteLine("Danke das du Darios Taschenrechner benutzt hast. Man sieht sich sicher wieder.");
                    f = false;
                }
            }
        }
    }
}
