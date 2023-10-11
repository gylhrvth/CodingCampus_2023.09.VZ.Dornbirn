using System;
namespace David.Week03
{
	public class Week03Day02Arrays
	{
		public static void Week03Day02()
		{

			//Aufgabe Aufsteigend 1
			Console.WriteLine("Aufgabe: Aufsteigend 1");

			int[] myArr = CreateArray(6);
            Console.WriteLine("[{0}]", string.Join(", ", myArr));
			Console.WriteLine();


			//Aufgabe Absteigend 2
			Console.WriteLine("Absteigend 2");

			int[] rep1 = Repeat1(6);
            Console.WriteLine("[{0}]", string.Join(", ", rep1));
			Console.WriteLine();

			//Aufgabe Kopie 3

			//ab hier das Original:
			Console.WriteLine("Kopie erstellen 3");

			int[] arr3 = NewArray4Copy(7);
			Console.WriteLine("[{0}]", string.Join(", ", arr3));

			//ab hier die Kopie:
			int[] copiedArray = MakeACopy(arr3); //Greift auf arr3 von Original zu.
            Console.WriteLine("[{0}]", string.Join(", ", copiedArray)); //Ausgabe der Kopie.
																		//Bis hier ist die Kopie 1:1.
			arr3[0] = 200; //jetzt wird die Kopie an Stelle "0" verändert,
						   //ohne das Original zu verändern.
						   //es bleibt eine 1:1 Kopie, bis es nochmals neu "gedruckt" wird.

			Console.WriteLine("Kopie, verändert");
            Console.WriteLine("[{0}]", string.Join(", ", arr3));//Jetzt mit veränderter Stelle.

			//Kopie wird nochmals mit "foreach"
			foreach (int element in arr3)
			{
				Console.Write(element + ", ");
			}

        }

        //----------------------------------------------------
        public static int[] CreateArray(int size)
		{
			int[] array1 = new int[size];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }
            return array1;
        }
		//----------------------------------------------------
		public static int[] Repeat1(int count)
		{
			int[] arrrep = new int[count];

			for (int i = 0; i < arrrep.Length; i++)
			{
				arrrep[i] = count - i;
			}
			return arrrep;
		}
        //----------------------------------------------------
		public static int[] NewArray4Copy(int zahl)
		{
			int[] array3 = new int[zahl];

			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = zahl - i;
			}
			return array3;
		}

		public static int[] MakeACopy(int[] original)
		{
			int[] copy = new int[original.Length];

			for (int i = 0; i < copy.Length; i++)
			{
				copy[i] = original[i]; //Hier entsteht die "Eigentliche" kopie.
			}                          //Der Array "Copy" soll gleich sein wie "Original".
			return copy;
		}
    }
}

