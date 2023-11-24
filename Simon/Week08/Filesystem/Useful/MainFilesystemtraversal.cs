using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class MainFilesystemtraversal
    {
        public static void Start()
        {


        }



        public static void FileTraversal(string path)
        {
            
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                IFileReceiver.OnfileRecived(0, path);



            }
            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                
                
                FileTraversal(dir);
            }
        }




    }
}
