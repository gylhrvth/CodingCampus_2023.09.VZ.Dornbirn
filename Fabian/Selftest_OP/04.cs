
namespace Fabian.Selftest_OP
{
    internal class _04
    {
        public static void Start()
        {
            string path = @"C:\Users\Anwender\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Fabian";
            PrintFile(GetBiggestFile(path));
        }

        public static string GetBiggestFile(string path)
        {
            string[] files = Directory.GetFiles(path);

            string biggestFilePath = "";
            double max = 0;

            foreach(string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Length > max)
                {
                    biggestFilePath = file;
                    max = fi.Length;
                }
            }
            return biggestFilePath;
        }

        public static void PrintFile(string file)
        {
            if (File.Exists(file))
                Console.WriteLine($"file: {file}, size: {new FileInfo(file).Length} B");
            else
                Console.WriteLine("File not found");
            
        }
    }
}
