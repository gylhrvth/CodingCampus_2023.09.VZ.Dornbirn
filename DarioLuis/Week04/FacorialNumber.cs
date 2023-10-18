using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week04
{
    public class FactorialExample
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Gib deine zahl ein: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Die faktoriale Zahl von " + number + " ist " + fact);
        }
    }
}