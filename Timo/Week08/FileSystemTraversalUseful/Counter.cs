using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    public class Counter: IFileReceiver
    {
        
        private int _FileCount = 0;
        private int _DirectoryCount = 0;

        
        
        public int GetFileCount()
        {
            return _FileCount;
        }
        public int GetDirectoryCount()
        {
            return _DirectoryCount;
        }

        public void OnFileReceived(int depth, string path)
        {
            _FileCount++;
        }

        public void OnDirectoryReceived(int depth, string path)
        {
            _DirectoryCount++;
        }
    }
}
