using System.Text;

namespace Fabian.Week08
{
    public class FileCopy
    {
        public static void Start()
        {
            string path = "C:\\Users\\fakr\\Documents\\textnis.txt";
            string newPath = "C:\\Users\\fakr\\Documents\\textnis2.txt";
            CopyTextFileStream(path, newPath);
        }

        public static void CopyTextFile(string path, string newPath)
        {
            try
            {
                string text = File.ReadAllText(path);
                File.WriteAllText(newPath, text);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        public static void CopyTextStreamWriter(string path, string newPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? data;
                    string text = "";
                    while ((data = sr.ReadLine()) != null)
                    {
                        text += data + "\n";
                    }
                    using (StreamWriter sw = new StreamWriter(newPath, false))
                    {
                        sw.WriteLine(text);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }

        public static void CopyTextFileStream(string path, string newPath)
        {
            try
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    string copy = "";
                    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                    {
                        copy += temp.GetString(b, 0, readLen);
                    }
                    byte[] b2 = new UTF8Encoding(true).GetBytes(copy);
                    using (FileStream fsw = File.OpenWrite(newPath))
                    {
                        fsw.Write(b2, 0, b2.Length);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public static void CopyTextToUpperFile(string path, string newPath)
        {
            try
            {
                string text = File.ReadAllText(path);
                File.WriteAllText(newPath, text.ToUpper());
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public static void CopyTextToUpperStreamWriter(string path, string newPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string? data;
                    string text = "";
                    while ((data = sr.ReadLine()) != null)
                    {
                        text += data + "\n";
                    }
                    using (StreamWriter sw = new StreamWriter(newPath, false))
                    {
                        sw.WriteLine(text.ToUpper());
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }
        public static void CopyTextToUpperFileStream(string path, string newPath)
        {
            try
            {
                using (FileStream fs = File.OpenRead(path))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    int readLen;
                    string copy = "";
                    while ((readLen = fs.Read(b, 0, b.Length)) > 0)
                    {
                        copy += temp.GetString(b, 0, readLen);
                    }
                    byte[] b2 = new UTF8Encoding(true).GetBytes(copy.ToUpper());
                    using (FileStream fsw = File.OpenWrite(newPath))
                    {
                        fsw.Write(b2, 0, b2.Length);
                    }
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
