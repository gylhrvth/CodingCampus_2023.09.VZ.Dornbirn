using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files.Interface
{
    public class FileAndCounter : TraverUsefulInterface
    {

        private int _counterFolder = 0;
        private int _counterFile = 0;
        public FileAndCounter() { }

        public void OnFileReceived(int depth, string path)
        {
            _counterFile++;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            _counterFolder++;
        }
    }
}
