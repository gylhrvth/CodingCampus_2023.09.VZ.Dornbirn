using System.IO;

namespace Erik.Week09.Filesystem
{
    internal class Traversal
    {
        public static void Start()
        {
            string rootPath = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Erik";
            NavigateToFolder(rootPath, "> ");

        }

        public static void NavigateToFolder(string rootPath, string prefix)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(rootPath);
            DirectoryInfo[] dir = directoryInfo.GetDirectories();
            FileInfo[] files = directoryInfo.GetFiles();


            foreach (DirectoryInfo dirElements in dir)
            {
                double fileMb = DirectoryClass.GetFilesSizeInByte(dirElements, 3);
                if (dirElements.GetFiles().Length == 0 && dirElements.GetDirectories().Length == 0)
                {
                    Console.WriteLine(prefix + "(Folder) " + dirElements.Name + " 0mb");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("    " + prefix + "  No files in folder! ");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(prefix + "(Folder) " + dirElements.Name + " / " + fileMb + "mb");
                    rootPath = dirElements.FullName;
                    NavigateToFolder(rootPath, "   " + prefix);
                }

            }

            foreach (FileInfo fileInf in files)
            {

                Console.WriteLine(prefix + "(File)" + fileInf.Name);
            }
        }
    }
}
