using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week06.HumanSizes
{
    public class HumanExample
    {
        public static void Start()
        {

            Console.WriteLine("Wie heißt du?");
            string nameOfUser = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nWie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWie schwer bist du?");
            int weigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWie groß bist du?");
            int size = Convert.ToInt32(Console.ReadLine());

            Human person = new Human(nameOfUser,age,weigth,size);
            Console.WriteLine(person);

        }
    }
}
