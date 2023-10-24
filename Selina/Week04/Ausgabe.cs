namespace Selina.Week04.Ausagbe
{
    internal class Ausgabe
    {

        //Output Aufgabe mit Farbe
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}");
            Console.ResetColor();

            return output;
        }

        //OutputForUser: das Ergebnis der jeweiligen Aufagben 
        public static void OutputForUser(int[] randomArray)
        {
            bool first = true;
            Console.Write("[");
            foreach (int num in randomArray)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(num);
                first = false;
            }
            Console.WriteLine("]");
        }



    }
}



