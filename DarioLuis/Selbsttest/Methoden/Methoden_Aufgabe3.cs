using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Methoden
{
    public  class Methoden_Aufgabe3
    {
        //Methode1 alles neu
        public static void Methode1()
        {
            //StrippleX
            Console.WriteLine("Hallo, das ist der graphische Darsteller von Dario");

            //Symbolnachfrage
            Console.WriteLine("Was soll das Symbol sein das gedruckt wird?");
            String symbol = Console.ReadLine();

            //Anzahlnachfrage
            Console.WriteLine("Wie lang und wie breit soll die Darstellung sein?");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= amount - 2; i++) 
            {
                Console.Write(symbol);
                Console.Write(" ");
            }

            //RowX
            for (int i = 0;i <= amount; i++) 
            {
                Console.WriteLine(symbol);
                Console.WriteLine(" ");
            }
        }
        //Methode2 den letzten Code verwenden
        public static void Methode2()
        {
            DarioLuis.Selbsttest.Methoden.Methoden_Aufgabe1.PrintLineStripple();
            DarioLuis.Selbsttest.Methoden.Methoden_Aufgabe2.PrintRowTrippleX();
        }

    }
}
