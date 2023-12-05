using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public interface IFileReceiver
    {

        public void OnFileRecived(int depth, string path);

        public void OnDirectoryReceived(int depth, string path);

    }
}
