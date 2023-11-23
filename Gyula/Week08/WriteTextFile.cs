using System;
namespace Gyula.Week08
{
	public class WriteTextFile
	{
		public static void Start()
		{
			using (StreamWriter sw = new StreamWriter("/Users/gyula.horvath/hello.txt", true))
			{
				sw.WriteLine("Hello World 2!");
			}
		}
	}
}

