using System;
using System.IO;
namespace Mohammed.Week08.FileSystem
{
	public class Recursion
	{
		public static void Start()
		{
            //Console.WriteLine("The sum from 1 to 10 is; "+ Sum(10));
            //Console.WriteLine("The Random above 50:" + GetRandomNumAbove50andBelow55());
            //Console.WriteLine("The Factoral is: " + FactorialRecursive(10));

			
			string path = "mohammedal-saraji@MacBook-Air-von-Mohammed CodingCampus_2023.09.VZ.Dornbirn";
			DisplayFolders(path, " ");
        }

		public static int Sum(int num)
		{
			if(num < 0)
			{
				return 0;
			}
			Console.WriteLine(num + "+ Sum( " + (num - 1)+ ")");
			int result = num + Sum(num - 1);
			Console.WriteLine("===>" + num + " " + result);

			return result;


		}

		public static int GetRandomNumAbove50andBelow55()
		{
			Random rand = new Random();

			int num = rand.Next(0, 55);

			if(num > 50)
			{
				return num;
			}
			else
			{
				Console.WriteLine("TEST ");

				return GetRandomNumAbove50andBelow55();
			}

		}

		public static int FactorialRecursive(int num)
		{
			if (num == 0)
				return 1;
			return num * FactorialRecursive(num - 1);

		}
		//???????????????
		public static void DisplayFolders(string preafix, string path)
		{
			if(Directory.Exists(path))
			foreach(var folder in Directory.GetDirectories(path))
			{
				Console.WriteLine($"{new string(' ' + path)} {Path.GetFileName(preafix)}");
				DisplayFolders(preafix, path + 1);
			}
		}

	}
}

