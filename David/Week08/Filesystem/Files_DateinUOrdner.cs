using System;
namespace David.Week08.Filesystem
{
	public class Files_DateinUOrdner
	{
		public Files_DateinUOrdner()
		{
		}

		public static void Start()
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			Console.WriteLine(currentDirectory);
			Console.WriteLine();

			string[] children = Directory.GetFiles(currentDirectory);

			var currentDirectroryInfo = new DirectoryInfo(currentDirectory);
			string rootDirectory = currentDirectroryInfo.Parent.Parent.Parent.Parent.Parent.Parent.FullName;
			Console.WriteLine(rootDirectory);

			foreach (var directory in currentDirectory)
			{
				Console.Write(directory);
			}

			foreach (var child in children)
			{
				FileInfo fileInfo = new FileInfo(child);

				Console.WriteLine(fileInfo.Name + " --> " + Math.Round(ConvertToMByte(fileInfo.Length), 2) + "KB");
			}
		}

        public static float ConvertToMByte(long sizeInByte)
        {
            return sizeInByte / 1024.0f;
        }
    }
}


