using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    internal class CountEnd : IFileReceiver
    {
        private string _Extention;
        private int _Count;
        public CountEnd(string extention) 
        {
            _Extention = extention;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
        }

        public void OnFileReceived(int depth, string path)
        {
            if (path.EndsWith(_Extention))
            {
                _Count++;
            }
        }
        public int ExtentionCount()
        {
            return _Count;
        }
    }
}
