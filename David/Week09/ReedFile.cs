using System;
using System.Runtime.InteropServices.Marshalling;

namespace David.Week09
{
	public class ReedFile
	{
		public static void Start()
		{
			using (StreamReader sr = new StreamReader("/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Hello.txt"))
			{
				string line = sr.ReadLine();
				while ( line != null)
				{
					Console.WriteLine(line);
					line = sr.ReadLine();
				}
			}

		}
	}
}

