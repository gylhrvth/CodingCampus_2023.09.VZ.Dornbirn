using System;
using System.IO; //Input/Output

namespace David.Week08.FilesDirectoriesPath
{
	class Files
	{
		static void Start()
		{
			string path = "test.txt";
			File.Create(path);
		}
	}
}

