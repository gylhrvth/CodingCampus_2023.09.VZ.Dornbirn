using System.IO;

namespace Timo.Selbsttest_OOP
{
    public class Aufgabe5
    {
        public static void Start()
        {
<<<<<<< HEAD
            //Pfad =C:\Users\aau27722\source\Repos\CodingCampus_2023.09.VZ.Dornbirn\Timo
            PrintBiggestFile(BiggestFile(ReadUserInput()));
=======
        //Pfad =C:\Users\aau27722\source\Repos\CodingCampus_2023.09.VZ.Dornbirn\Timo
        



            PrintBiggestFile(BiggestFile(ReadUserInput()));

>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
        }
        public static string ReadUserInput()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie den zu überprüfenden Pfad ein: ");
                string path = Console.ReadLine();

                if (File.Exists(path) || Directory.Exists(path))
                {
<<<<<<< HEAD
                    return path;
=======
                    Console.WriteLine(".");
                    return path;
                    
>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Could not find '{0}'", path);
<<<<<<< HEAD
                    Console.ResetColor();
                }
            }

        }
        public static string BiggestFile(string path, long maxLen = 0, string pfad = "")
        {
=======
                    Console.ResetColor(); 
                }
            }
            
        }
        public static string BiggestFile(string path, long maxLen=0, string pfad="")
        {
            if (File.Exists(path) || Directory.Exists(path))
            {
>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);
                string PathOfBiggestFile = pfad;
                long maxLength = maxLen;
<<<<<<< HEAD
=======
                //if (Directory.Exists(path) )
                //{
>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if (fileInfo.Length > maxLength)
                    {
                        PathOfBiggestFile = fileInfo.FullName;
                        maxLength = fileInfo.Length;
<<<<<<< HEAD
=======
                        //Console.WriteLine(fileInfo.Name);
>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
                    }
                }
                foreach (string directory in directories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directory);
<<<<<<< HEAD
                    PathOfBiggestFile = BiggestFile(directoryInfo.FullName, maxLength, PathOfBiggestFile);
                }
                return PathOfBiggestFile;
        }
        public static void PrintBiggestFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine("Größte Datei: " + fileInfo.Name + ", Größe in Byte: " + fileInfo.Length);
=======
                    //PathOfBiggestFile = directoryInfo.FullName;
                    PathOfBiggestFile = BiggestFile(directoryInfo.FullName, maxLength, PathOfBiggestFile);
                }

                return PathOfBiggestFile;
            }
            else
            {
                return "Error";
            }
        }
        public static void PrintBiggestFile(string path/*, string originalPath*/)
        {
            //if (path == "Error")
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine("Could not find '{0}'", originalPath);
            //    Console.ResetColor();
            //}
            //else
            //{
                FileInfo fileInfo = new FileInfo(path);
                Console.WriteLine(fileInfo.Name + " " + fileInfo.Length);
            //}
>>>>>>> d9d9b6213985fd496ae75d3703441ad9d74b9403
        }
    }
}