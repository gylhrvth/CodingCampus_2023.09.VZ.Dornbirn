using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class CountFilesFolders : IFileReceiver
    {

        private int _Count;

        public CountFilesFolders()
        {
            _Count = 0;
        }

        public int Count {  get { return _Count; } }
        

        public void OnFileRecived(int depth, string path)
        {
            _Count++;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            _Count++;
        }

    }
}
