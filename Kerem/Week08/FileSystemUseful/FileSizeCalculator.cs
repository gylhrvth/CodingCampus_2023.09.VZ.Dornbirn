using Kerem.Week08.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.FileSystemUseful
{
    internal class FileSizeCalculator : IFileReceiver
    {
        private long _OverallFileSizeInBytes = 0;

        public long OverallFileSizeInBytes { get => _OverallFileSizeInBytes; }

        public FileSizeCalculator()
        {

        }

        public void OnFileReceived(int depth, string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            _OverallFileSizeInBytes += fileInfo.Length;
        }
        public void OnDirectoryReceived(int depth, string path)
        {

        }
    }
}
