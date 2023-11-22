using System;
using System.IO;

namespace Gyula.Week08
{
	public class FileList
	{
		public static void Start()
		{
			string path = "/Users/gyula.horvath/Projects/CodingCampus_2023.09.VZ.Dornbirn/Gyula/Week08";

			PrintDirectoryStruct("", path);
/*
            Console.WriteLine($"Is anybody at home? {Directory.Exists(path)}");

			string[] subDirectories = Directory.GetDirectories(path);
			foreach (string p in subDirectories)
			{
				Console.WriteLine(p);
			}
*/
        }


		public static void PrintDirectoryStruct(string prefix, string path)
		{
			if (Directory.Exists(path))
			{
				Console.WriteLine(prefix + path);
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string p in subDirectories)
                {
					PrintDirectoryStruct("  " + prefix, p);
                }

				string[] fileList = Directory.GetFiles(path);
				Console.ForegroundColor = ConsoleColor.Blue;
				foreach (string fileName in fileList)
				{
					FileInfo info = new FileInfo(fileName);
					Console.WriteLine($"{info.Length,7} {prefix} {fileName}");
				}
				Console.ForegroundColor = ConsoleColor.White;
            }
		}
	}
}

