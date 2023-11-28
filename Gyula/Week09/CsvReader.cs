using System;
namespace Gyula.Week09
{
	public class CsvReader
	{
		public static void Start()
		{
			using (StreamReader sr = new StreamReader("/Users/gyula.horvath/web/CodingCampus_2023.03.VZ.Dornbirn/src/main/resources/csv/sales_100.csv"))
			{
				string line = sr.ReadLine();
				while (line != null)
				{
					ProcessLine(line);

					line = sr.ReadLine();
				}
			}
		}

		public static void ProcessLine(string line)
		{
			string[] columns = line.Split(",");
			for (int i = 0; i < columns.Length; i++)
			{
				Console.Write("| {0,35} ", columns[i]);
			}
			Console.WriteLine("|");
		}
	}
}

