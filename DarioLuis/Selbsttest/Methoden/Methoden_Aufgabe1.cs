using System.Linq.Expressions;

namespace DarioLuis.Selbsttest.Methoden
{
    public class Methoden_Aufgabe1
    {
        public static void Start()
        {
            char symbol = '█';
            int amount = 9;
            for (int i = 0;i <= amount; i++) 
            {
                Console.Write(symbol);
                Console.Write(" ");
            }

        }
            
        
    }
}
