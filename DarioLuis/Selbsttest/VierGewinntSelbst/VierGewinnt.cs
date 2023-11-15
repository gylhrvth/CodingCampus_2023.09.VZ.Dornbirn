using System;

namespace DarioLuis.Selbsttest.VierGewinnt 
{ 
    public class VierGewinntSlebst
    {
        public static void Start()
        {
            Printboard();
        }

        static string[] arr = { "1", "2", "3", "4", "5" };
        public static void Printboard()
        {
            Console.WriteLine(" 1  2   3   4   5");
            Console.WriteLine("___________");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|");
            Console.WriteLine("___________");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|");
            Console.WriteLine("___________");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|");
            Console.WriteLine("___________");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|");
            Console.WriteLine("___________");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|");
            Console.WriteLine("___________");
        }
    }
}
    