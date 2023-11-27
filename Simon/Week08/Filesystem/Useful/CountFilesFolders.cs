using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class CountFilesFolders : IFileReceiver
    {

        private int _FileCount;
        private int _FolderCount;

        public CountFilesFolders()
        {
            _FileCount = 0;
            _FolderCount = 0;
        }

        public int FileCount { get { return _FileCount; } }
        public int FolderCount { get { return _FolderCount; } }


        public void OnFileReceived(int depth, string path)
        {
            _FileCount++;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            _FolderCount++;
        }

    }
}
