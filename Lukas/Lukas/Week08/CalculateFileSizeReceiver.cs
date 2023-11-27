using System;
namespace Lukas.Week08
{
	public class CalculateFileSizeReceiver : FileReceiver
	{
		private long _OverallFileSizeInBytes = 0;

		public long overallFileSizeInBytes { get => _OverallFileSizeInBytes; }

		public CalculateFileSizeReceiver()
		{
		}

		public void OnFileReceived(int depth, string path)
		{
			FileInfo info = new FileInfo(path);
			_OverallFileSizeInBytes += info.Length;
		}

		public void OnDirectoryReceived(int depth, string path)
		{

		}
	}
}

