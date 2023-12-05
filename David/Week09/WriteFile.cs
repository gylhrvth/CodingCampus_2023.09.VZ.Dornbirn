using System;
namespace David.Week09
{
	public class WriteFile
	{
		public static void Start()
		{
			using (StreamWriter sw = new StreamWriter("/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Hello.txt"))
			{
				sw.WriteLine("Hello World!");
			}
		}
	}
}

