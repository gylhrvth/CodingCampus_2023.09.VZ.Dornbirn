using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class StringFormat
    {
        public static void Start()
        {

            string name;
            Console.Write("Please enter your name and press enter: ");
            name = Console.ReadLine();
            string nameUpperCase = String.Format("Upper case: {0}", name.ToUpper());
            string nameLowerCase = String.Format("Lower case: {0}", name.ToLower());
            string nameTrimmed = String.Format("Timmed value: {0}", name.Trim());
            string nameSubstring = String.Format("Substring value: {0}", name.Substring(0,2));

            Console.WriteLine(nameUpperCase);
            Console.WriteLine(nameLowerCase);
            Console.WriteLine(nameTrimmed);
            Console.WriteLine(nameSubstring);


            Console.WriteLine("========================================");

            Console.Write("Enter the string here: ");
            //Read first input string.
            string input = Console.ReadLine();

            Console.Write("Enter a Character to search: ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];
            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0}, in string is {1}", searchInput, searchIndex);


            Console.WriteLine("=========================================");
            //Read the first name
            Console.Write("Enter first name: ");
            string firstname = Console.ReadLine();

            //Read the last name
            Console.Write("Enter last name: ");
            string lastname = Console.ReadLine();

            //Concatinate the firstname and lastname variable and assign that to fullname variable.
            string fullname = string.Concat(firstname," " ,lastname);

            //Prints the full name on the console.
            Console.WriteLine("Your full name is {0}", fullname);



        }
    }
}
