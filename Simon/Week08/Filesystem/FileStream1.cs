using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem
{
    public class FileStream1
    {
        public static void Start()
        {
            string path = "C:\\Users\\BAU21982\\OneDrive - Julius Blum GmbH\\Desktop\\test.txt";
            string readfile = ReadTextFile(path);
            Console.WriteLine(readfile);
        }

        public static string ReadTextFile(string path)
        {
            FileStream filestream = null;
            StreamReader reader = null;
            try
            {
                filestream = File.OpenRead(path);
                reader = new StreamReader(filestream, Encoding.UTF8);

                string file = reader.ReadToEnd();

                return file;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (filestream != null)
                {
                    filestream.Close();
                }
            }
        }
        public static string ReadTextFile1(string filePath)
        {
            using (FileStream fileStream = File.OpenRead(filePath))
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string fileContent = streamReader.ReadToEnd();
                return fileContent;
            }
        }





    }
}
