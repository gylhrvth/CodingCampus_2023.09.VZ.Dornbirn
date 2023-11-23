using System;
namespace Gyula.Week08
{
	public class ReadTextFile
	{
		public static void Start()
		{
			using (StreamReader sr = new StreamReader("/Users/gyula.horvath/hello.txt"))
			{
				string line = sr.ReadLine();
				while (line != null)
				{
					Console.WriteLine(line);
					line = sr.ReadLine();
				}
			}
		}
	}
}

