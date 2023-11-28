using System;
namespace David.Week08.Filesystem.Filesystem
{
	public class FileAndFolderCounter : FileReceiver
	{
		public int _CountFolder = 0;
        public int _CountFile = 0;

		public int CountFolder { get => _CountFolder; }
		public int CountFile { get => _CountFile; }

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

