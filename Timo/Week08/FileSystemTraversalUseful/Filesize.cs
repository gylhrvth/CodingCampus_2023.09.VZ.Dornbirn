using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    internal class Filesize : IFileReceiver
    { 
        private long _FileSize;
        public void OnDirectoryReceived(int depth, string path)
        {

        }
        public void OnFileReceived(int depth, string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            _FileSize += fileInfo.Length;
        }

        public long GetFileSize ()
        {
            return _FileSize;
        }
    }
}
