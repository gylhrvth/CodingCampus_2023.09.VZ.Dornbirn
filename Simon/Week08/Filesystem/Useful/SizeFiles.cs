using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class SizeFiles : IFileReceiver
    {
        private int _Size;
        public SizeFiles(int size)
        {
            _Size = size;
        }
        public int Size {  get { return _Size; } }

        public void OnFileRecieved()
        {

        }

        public void OnDirectoryRecieved()
        {

        }

    }
}
