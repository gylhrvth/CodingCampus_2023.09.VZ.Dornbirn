namespace Lukas.Week03
{
    public class Array2DMatrix
	{
		public Array2DMatrix()
		{
		}

		public static void Start()
		{
            array2D();
            //matrix();
		}

		public static void array2D()
		{
            Random r = new Random();
            //height: 10, width: 5
            int[][] arr2D = new int[10][];

			for(int row = 0; row < arr2D.Length; row++)
			{
                //Random: arr2D[row] = new int[r.Next(0, 10)];
                arr2D[row] = new int[5];
            }

			//Fill with random numbers
			
			for(int row = 0; row< arr2D.Length; row++)
			{
				for(int col = 0; col < arr2D[row].Length; col++)
				{
					arr2D[row][col] = r.Next(10, 100);
				}
			}

            //Print
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    Console.Write(arr2D[row][col]+ " ");
                }
				Console.WriteLine();
            }
        }

		public static void matrix()
		{
            //height: 10, width: 5
            int[,] mat = new int[10,5];

            //Fill with random numbers
            Random r = new Random();
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    mat[row, col] = r.Next(10, 100);
                }
            }

            //Print
            for (int row = 0; row < mat.GetLength(0); row++)
            {
                for (int col = 0; col < mat.GetLength(1); col++)
                {
                    Console.Write(mat[row, col] + " ");
                }
                Console.WriteLine();
            }

            foreach(int entry in mat)
            {
                Console.Write(entry+" ");
            }
        }
	}
}

