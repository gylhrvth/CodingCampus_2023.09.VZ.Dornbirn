using System;
namespace David.Week03
{

    public class Random2
	{
        public static Random random = new Random();

        public static void Start()
		{
            //Beispiel Random Number2:
			Console.WriteLine("Beispiel Random Number 2:");

			int[] arr3 = Random(10);
			Console.WriteLine(String.Join(", ", arr3));
            Console.WriteLine();


            //Beispiel Random 3, Ausgabe Stelle 2, 5, 10:
			Console.WriteLine("Beispiel Random Number3:");

            Console.WriteLine(arr3[1]+ " " +arr3[4] + " "+ arr3[9]);
            Console.WriteLine();


            //Beispiel Random 4, Ausgabe jeder 2. Wert:
            Console.WriteLine("Beispiel Random Number4:");

            for (int i = 0; i < arr3.Length; i += 2)
            {
                Console.Write(arr3[i] + ", ");
            }
            Console.WriteLine();

        }

        //Beispiel Random Number2,3,4,:
        public static int[] Random(int size)
		{
			int[] array = new int[size];

            for (int i = 1; i < array.Length; i++)
			{
				array[i] = random.Next(0, 101);
			}
			
			return array;
		}


	}
}

