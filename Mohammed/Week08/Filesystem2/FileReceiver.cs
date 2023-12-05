using System;
namespace Mohammed.Week08.Filesystem2
{
	public interface FileReceiver
	{
		public void OnFileReceiver(int depth, string path);
		public void OnDirectoryReceived(int depth, string path);

	}
}

