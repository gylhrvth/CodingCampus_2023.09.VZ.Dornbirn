using System;
namespace Gyula.Week08
{
	public class ReadTextFile
	{
		public static void Start()
		{
			//jlasncasc
			using (StreamReader sr = new StreamReader("/Users/gyula.horvath/hello.txt"))
			{
				//zum zeile lesen
				string line = sr.ReadLine();
				//wenn zeile NICHT Leer ist dann ....
				while (line != null)
				{
					
					Console.WriteLine(line);
					
					line = sr.ReadLine();
				}
			}
		}
	}
}

