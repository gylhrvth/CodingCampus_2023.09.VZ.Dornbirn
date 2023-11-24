using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    public class FileAndFolderCounter : FileReceiver
    {
        private int _CountFolder = 0;
        private int _CountFile = 0;

        public int CountFolder { get => _CountFolder; }
        public int CountFiles { get => _CountFile; }

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
