
namespace Erik.Week10
{
    internal class Main
    {
        public static void Start()
        {
            WriteFile();
            ReadFile();
            Console.WriteLine();

            string path = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Erik\\Week10\\Hey.txt";
            string copyToPath = "C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Erik\\";
            CopyFile(path, copyTo)
        }

        public static void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Erik\\Week10\\Hey.txt"))
            {
                sw.WriteLine("Hello World");
            }
        }

        public static void ReadFile()
        {
            using (StreamReader sr = new StreamReader("C:\\Users\\DCV\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Erik\\Week10\\Hey.txt"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }

        public static void CopyFile(string copy, string copyTo)
        {
            

        }
    }
}

