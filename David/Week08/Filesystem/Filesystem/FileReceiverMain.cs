using System;
using David.Week08.Filesystem.Filesystem;
namespace David.Week08.Filesystem
{
	public class FileReceiverMain
	{
		public static void Start()
		{
			string path = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David";
			FileAndFolderCounter ffc = new FileAndFolderCounter();

			NavigateFilesystem(0, path, ffc);

			Console.WriteLine("FolderCount: " + ffc.CountFolder);

			Console.WriteLine("FileCount: " + ffc.CountFile);
		}

		public static void NavigateFilesystem(int depth, string path, FileReceiver fr)
		{
			string[] files = Directory.GetFiles(path);
			string[] folders = Directory.GetDirectories(path);

			foreach (var file in files)
			{
				fr.OnFileReceived(depth, file);
			}
			foreach (var folder in folders)
			{
				fr.OnDirectoryReceived(depth, folder);
				NavigateFilesystem(depth + 1, folder, fr);
			}
		}
    }
}