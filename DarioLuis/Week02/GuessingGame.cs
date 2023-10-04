namespace DarioLuis.Week02
{
    class GuessingGame
    {
        public static void Start()
        {
            Random random = new Random();
            int pcGuess = random.Next(1, 101);
            int Guess = 0;

            Console.WriteLine("Hallo ich denke gerade an eine Zahl zwischen 1 und 100. Kannst du die Nummer erraten?");
            while (Guess != pcGuess)
            {
                Guess = 0;
                while (Guess == 0) { 
                    try
                    {
                        string line = Console.ReadLine();
                        Guess = Convert.ToInt32(line);
                        if  (Guess < 1 || Guess > 100)
                        {
                            Console.WriteLine("Dieses Spiel braucht eine Zahl zwischen 1 und 100.");
                            Guess = 0;
                        }
                    } catch (FormatException fe)
                    {
                        Console.WriteLine("Es ist keine Zahl");
                    } catch (OverflowException oe)
                    {
                        Console.WriteLine("Sooooo groß soll es doch nicht sein");
                    }
                }


                if (Guess < pcGuess)
                {
                    Console.WriteLine("Ich denke an eine größere Zahl wie " + Guess);
                }
                else if (Guess > pcGuess)
                {
                    Console.WriteLine("Ich denke an eine kleiner Zahl wie " + Guess);
                }
            }
            Console.WriteLine("DAS WAR DIE RICHTIGE ZAHL SEHR GUT GEMACHT. DIE ZAHL WAR: " + pcGuess);
        }
    }
}
