using System.Linq.Expressions;

namespace DarioLuis.Selbsttest.Methoden
{
    public class Methoden_Aufgabe1
    {
        public static void PrintLineStripple()
        {
            char symbol = 'X';

            Console.WriteLine("Wie lang soll die Reihe sein?");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;i <= amount - 1; i++) 
            {
                Console.Write(symbol);
                Console.Write(" ");
            }
            Console.WriteLine();

        }
            
        
    }
}
