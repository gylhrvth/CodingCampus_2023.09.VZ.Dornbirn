 using System;
namespace Mohammed.Week08.Filesystem2
{
	public class FileCounter
	{
		public int Files = 0;
		public int Directories = 0;

		public void  OnFile(FileInfo fileInfo)
		{
			Files++;
		}

		public void OnDirectory(DirectoryInfo directoryinfo)
		{
			Directories++;
		}
	}
}

