using System;
namespace David.Week03
{
	public class Week03Day03RandomArrays
	{
		public static Random rand = new Random(10);


        public static void StartWeek03Day03RandomArrays()
		{
            //----------Random Array 1--------------

            int[] randarray = RandomA(10); // Hier wird die Methode benennt und die Size definiert.

            //Console.WriteLine("---");
            //Console.WriteLine(String.Join(",", randarray));

            //----------Random Array 2--------------

            //int[] random2 = Random2(10);
        }

        //----------Random Array 1--------------
        public static int[] RandomA(int size) // Hier wird die Methode und size abgerufen.
		{

            int[] arrayRand1 = new int[size];// Hier wird der eigentliche Arr erstellt und Speicher Reserviert
			for (int i = 0; i < arrayRand1.Length; i++)// Hier werden die Durchläufe festgelegt.
			{
				arrayRand1[i] = rand.Next(0, 101);// Hier wird gesagt was in die Felder kommt.
            }
            foreach (int element in arrayRand1)// für jedes int "element" in Array schreibe ein
            {
                Console.Write(element + ", ");  // element  + ", ".
            }
            Console.WriteLine();
			return arrayRand1;// Hier gitbt "return" den Wert von arrayRanjd1 an die Methode oben zurück.
		}

        //----------Random Array 2--------------
  //      public static int[] Random2(int size)
		//{
		//	int[] RaArr2 = new int[size];
		//}
	}

}

