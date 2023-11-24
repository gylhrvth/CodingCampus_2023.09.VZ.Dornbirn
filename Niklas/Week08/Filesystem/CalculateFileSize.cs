using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    internal class CalculateFileSize : FileReceiver
    {
        private long _OverallFileSizeInBytes = 0;

        public long overallFileSizeInBytes { get => _OverallFileSizeInBytes; }

        public CalculateFileSize()
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
