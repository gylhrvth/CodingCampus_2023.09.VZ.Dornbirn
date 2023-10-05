using DarioLuis.Week01;

namespace DarioLuis.Week02
{
    class Menü
    {
        public static void Start()
        {
            bool again = true;
            while (again)
            {
                Console.WriteLine("Wilkommen bei meiner Aufgabe!");
                Console.WriteLine("Was möchtest du Abbilden lassen?");

                Console.WriteLine("1)Quader");
                Console.WriteLine("2)Triangle");
                Console.WriteLine("3)Rhombus");



                int eingabe = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wie groß soll das Objekt sein?");
                int zahl = Convert.ToInt32(Console.ReadLine());

                switch (eingabe)
                {
                    case 1:
                        {
                            Methoden.PrintEmptySquare2("x", zahl);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            Methoden.PrintBigTriangle("x", zahl);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        {
                            Methoden.PrintRhombus("x", zahl);
                        }
                        break;
                }

                Console.WriteLine("Magst du nochmal rechnen?(j/n)");
                string ans = Convert.ToString(Console.ReadLine());

                if (ans == "n")
                {
                    Console.WriteLine("Danke es hat mich gefreut komm gern wieder, ich weiß du bist nicht der beste in Mathe!!");
                    again = false;
                }
            }
        }
    }
}
