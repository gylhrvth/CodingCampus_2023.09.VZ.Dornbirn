using System;
namespace Gyula.Week09
{
	public class FileCopy
	{
		public static void Start()
		{
			CopyTo("", "");
		}

		public static void CopyTo(string source, string destination)
		{
			using (StreamReader rs = new StreamReader(source))
			{
				using (StreamWriter sw = new StreamWriter(destination))
				{
					string line = rs.ReadLine();

					while (line != null)
					{
						sw.WriteLine(line);
						line = rs.ReadLine();
					}
				}
			}
		}
	}
}

