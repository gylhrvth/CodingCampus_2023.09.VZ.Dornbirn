using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08
{
    public class ReadAndWrite
    {
        public static void Start()
        {

            string file = "C:\\Users\\BAU27722\\OneDrive - Julius Blum GmbH\\Dokumente\\Textnis.txt";
            string file2 = "C:\\Users\\BAU27722\\OneDrive - Julius Blum GmbH\\Dokumente\\Textnis75.doc";
            string newText = "hello world";


            //CopyTextFile(file, file2);
            //CopyTextStreamWriter(file, file2);
            //CopyTextFileStream(file, file2);
            CopyTextFileToUpper(file, file2);



        }
        public static void CopyTextFile(string file, string file2)
        {
            try
            {
                string copy = File.ReadAllText(file);
                File.AppendAllText(file2, copy);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CopyTextStreamWriter(string file, string file2)
        {
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string? data;
                    string copy = "";
                    while ((data = reader.ReadLine()) != null)
                    {
                        copy += data + "\n";
                    }
                    using (StreamWriter writer = new StreamWriter(file2, true))
                    {
                        writer.WriteLine(copy);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CopyTextFileStream(string file, string file2)
        {
            try
            {
                using (FileStream fs = File.OpenRead(file))
                {
                    byte[] data = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    string copy = "";
                    while ((readLen = fs.Read(data, 0, data.Length)) > 0)
                    {
                        copy += temp.GetString(data, 0, readLen);
                    }
                    byte[] bytes = new UTF8Encoding(true).GetBytes(copy);
                    using (FileStream fs2 = File.OpenWrite(file2))
                    {
                        fs2.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CopyTextFileToUpper(string file, string file2)
        {
            try
            {
                string copy = File.ReadAllText(file);
                copy = copy.ToUpper();
                File.AppendAllText(file2, copy);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
