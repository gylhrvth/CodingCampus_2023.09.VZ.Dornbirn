using System;
using System.IO; //Input/Output

namespace David.Week08.FilesDirectoriesPath
{
	public class Files
	{
		public static void Start()
		{
			string path = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Files/Hello3.txt";
			//CREATE FILE
			File.Create(path);

			//READ FILE
			//string content = File.ReadAllText(path);
			//Console.WriteLine(content);

			//COPY FILE

			//if (File.Exists(path) == true)
			//{
			//string destPath = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David/Week08/Hello4.txt";
			//File.Copy(path, destPath);

			//}
			//else
			//{
			//	Console.WriteLine("Can't find file!");

			//	FileStream fs = File.Create(path);
			//	fs.Close();

			//	Console.WriteLine("Created file for you!");
			//	File.WriteAllText(path, "Hallo David!");
			//}

			//APPEND Anfügen

			//DELETE
			//if (File.Exists(path))
			//{
			//	File.Delete(path);
			//}

		}
	}
}

