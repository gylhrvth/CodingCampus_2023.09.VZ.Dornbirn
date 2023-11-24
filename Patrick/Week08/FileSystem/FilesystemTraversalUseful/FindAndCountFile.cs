using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    internal class FindAndCountFile : IFilereceiver
    {
        private int _Count = 0;

        public int Count
        {
            get => _Count;
        }
        public void OnFileReceived(int depth, string rootFolder)
        {

            FileInfo fileInfo = new FileInfo(rootFolder);
            string findFileName = fileInfo.FullName;
            string countains = "VehicleMain.cs";
            if (findFileName == countains)
            {
                _Count++;
            }
        }
        public void OnDirectoryReceived(int depth, string rootFolder)
        {


        }



    }
}
