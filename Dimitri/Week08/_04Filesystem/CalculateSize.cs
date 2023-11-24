using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    public class CalculateSize : IFileReceiver
    {
        private long _size;
        public long size { get => _size;  }

        public void OnFileReceived(int depth, string path)
        {
            FileInfo fileToAdd= new FileInfo(path);
            _size += fileToAdd.Length;
        }
        public void OnDirectoryReceived(int depth, string path)
        {

        }
    }
}
