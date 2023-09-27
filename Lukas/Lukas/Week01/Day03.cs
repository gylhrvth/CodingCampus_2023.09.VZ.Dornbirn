using System;
namespace Lukas.Week01
{
    public class Day03
    {
        public static void Start()
        {
            Console.WriteLine("Hello World!\n\n     /--\\\n    / /\\ \\\n   / /  \\ \\\n  / /    \\ \\\n /  ======  \\\n/_/        \\_\\\n");

            //Deklaration
            int y;
            //Zuweisung
            y = 11;

            //Deklaration mit Initialisierung
            int x = 10;

            String s = "Hallo";

            Console.WriteLine($"{s} {y} {x}");

            Console.WriteLine(s +" "+ y +" "+ x);

            Console.WriteLine(" " + y + x);

            Console.WriteLine(y + x + " ");

            bool online = true;

            if(online)
            {
                Console.WriteLine("Wir sind online! Hurra!!!");
            } else
            {
                Console.WriteLine("Wir sind nicht online! Schade");
            }


            int i = 0;


            if(i > 10)
            {
                Console.WriteLine("Das ist eine große Zahl!!!");
            }
            else if(i > 5)
            {
                Console.WriteLine("Das ist eine mittelgroße Zahl!!!");
            }
            else
            {
                Console.WriteLine("Das ist eine kleine Zahl!!!");
            }

            //Schleifen

            int j = 0;
            while(j < 10)
            {
                Console.WriteLine($"Ich bin in der While-Schleife!!! {j}");
                j = j + 1;
            }

            for(int k = 0; k < 10; k++)
            {
                Console.WriteLine($"Ich bin in der For-Schleife!!! {k}");
            }




            int z = 100;

            if(z % 2 == 0)
            {
                Console.WriteLine("Z ist gerade!!! " + z);
            } else
            {
                Console.WriteLine("Z ist ungerade!!! " + z);
            }


        }
    }
}