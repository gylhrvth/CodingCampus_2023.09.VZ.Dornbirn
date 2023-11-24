using System;
namespace Lukas.Week08
{
	public interface FileReceiver
	{
        public void OnFileReceived(int depth, string path);

        public void OnDirectoryReceived(int depth, string path);
    }
}

