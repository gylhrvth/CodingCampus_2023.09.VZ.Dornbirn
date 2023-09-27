using System;


namespace Martin.Week01
{
    public static class MyVarliablen
    {
        public static void Start()
        {

            /////// Aufgabe: Zählen

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); // schreibt jede zahl untereinander
            }

            int k = 0;

            while(k < 10)
            {
                Console.Write(k); // schreibt alles nebeneinander
                k++;
            }

            /////// Aufgabe: Zählen 2

            Console.WriteLine();

            for(int M = 0; M <= 10; M++) // zählt von 0 bis 10
            {
                Console.WriteLine(M); 
            }

            /////// Aufgabe: Zählen mit trick

            for(int n = 0; n <= 10; n++)
            {
                if(n % 2 == 0) //wenn die zahl keinen rest ergibt
                {
                    Console.WriteLine(n + "ist eine gerade zahl");
                } 
                else
                {
                    Console.WriteLine(n + "ist keine gerade zahl");
                }
            }

            /////// Aufgabe: Rewind
            
            for(int L = 10; L >= -10;L--)
            {
                Console.WriteLine(L);
            }
        }

    }
}
