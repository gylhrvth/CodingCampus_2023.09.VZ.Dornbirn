using System;
namespace Lukas.Week08
{
	public class Files1
	{
		public Files1()
		{
		}

		public static void Start()
		{
   			Traverse(Directory.GetCurrentDirectory());
        }

        public static void Traverse(string path)
		{
			Traverse(path, "");
		}


        public static void Traverse(string path, string indent)
		{
			if(Directory.Exists(path))
			{
				DirectoryInfo info = new DirectoryInfo(path);
				Console.WriteLine(indent + info.Name);
				foreach(string child in Directory.GetFiles(path))
				{
					Traverse(child, indent + "  ");
					//Console.WriteLine("    f: " + child);
				}
				foreach (string child in Directory.GetDirectories(path))
				{
                    //Console.WriteLine("    d: " + child);
                    Traverse(child, indent + "  ");
                }
			} else if(File.Exists(path))
			{
                FileInfo info = new FileInfo(path);
                Console.WriteLine(indent + info.Name+" "+info.Length+" byte");
            }
		}
	}
}

