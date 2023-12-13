using System;
namespace David.Week04.Udemy
{
	public class uebung
	{
		public static void Start()
		{
            List<int> ints = new List<int>();

            //Hinzufügen
            ints.Add(100);
            ints.Add(-100);
            ints.Add(500);

            //Entfernen
            bool success = ints.Remove(100);
            Console.WriteLine(success);

            //Clear all elements
            ints.Clear();

            //Einfügen am Index
            ints.Insert(0, 600);
            ints.Insert(1, 500);
            ints.Insert(2, 600);

            //Löschen am Index
            ints.RemoveAt(0);

            //Index holen
            int index = ints.IndexOf(500);
            Console.WriteLine(index);

            //Count
            int count = ints.Count();
            Console.WriteLine(count);
        }
	}
}

