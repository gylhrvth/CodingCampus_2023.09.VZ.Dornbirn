using System;
namespace Lukas.Week08
{
	public class FileAndFolderCounter : FileReceiver
	{
		private int _CountFolder = 0;
		private int _CountFile = 0;

		public int CountFolder { get => _CountFolder; }
		public int CountFile { get => _CountFile;  }

		public FileAndFolderCounter()
		{
		}

		public void OnFileReceived(int depth, string path)
		{
			_CountFile++;
		}

		public void OnDirectoryReceived(int depth, string path)
		{
			_CountFolder++;
		}
	}
}

