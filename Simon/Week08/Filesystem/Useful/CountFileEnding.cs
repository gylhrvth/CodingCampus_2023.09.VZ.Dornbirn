using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class CountFileEnding : IFileReceiver
    {
        private int _Count;
        private string _FileEnding;

        public CountFileEnding(string fileEnding)
        {
            _Count = 0;
            _FileEnding = fileEnding;
        }

        public int Count { get { return _Count; } }

        public void OnFileReceived(int depth, string path)
        {
            if (path.EndsWith(_FileEnding))
            {
                _Count++;
            }
        }
        public void OnDirectoryReceived(int depth, string path)
        {

        }

    }
}
