namespace Selina.Week08.Filesystem
{
    public class Filesystem_traversal
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string filesystem = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(filesystem);
            var dirs = new DirectoryInfo(filesystem);
            string projectDirectory = dirs.Parent.Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

    //public static void Files()
    //{
        
    //}
}
       
 
