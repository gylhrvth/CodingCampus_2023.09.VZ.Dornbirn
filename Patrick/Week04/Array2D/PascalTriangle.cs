
namespace Patrick.Week04
{
    internal class PascalTriangle
    {
        public static void Start()
        {
            // Wie groß möge es sein
            Console.Write("Wie viel Zeilen? >>> ");
            int rows = ConsoleInput.ReadNumber(1, 100);                                        //Erweitere deine frühere Lösung so, dass die Parameter über die Konsole eingegeben werden können
            Console.Write("Wie viel Spalten? >>> ");
            int columns = ConsoleInput.ReadNumber(1, 100);

            int[][] pascal = CreatePascalTriangle(rows, columns);
            Array2D.PrintArray(pascal);
        }


        public static int[][] CreatePascalTriangle(int rows, int columns)
        {
            int[][] array2D = new int[rows][];
            for (int i = 0; i < array2D.Length; i++)
            {
                array2D[i] = new int[columns];
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        array2D[i][j] = 1;
                    }
                    else
                    {
                        array2D[i][j] = array2D[i][j - 1] + array2D[i - 1][j];
                    }

                }
            }
            return array2D;

        }
    }
}
