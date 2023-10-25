using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Erik.Week05
{
    public class Emailregex
    {
        public static void Start()
        {
            Console.WriteLine("Enter a mail address!");
            Console.Write("Your mail address:");
            String userInput = Console.ReadLine();
            UserInputCheck(userInput);
        }

        public static void UserInputCheck(string userInput)
        {
            String validMail = userInput;
            String regex = "(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])";
            if (Regex.Match(validMail, regex).Success)
            {
                Console.WriteLine("Mail address is valid!");
            }
            else
            {
                Console.WriteLine("Mail address is not valid!");
            }

            Console.WriteLine();
            Console.WriteLine(Regex.IsMatch("alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina.alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina1.1alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("1rambina1.alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("asdf@drlue", regex));
            Console.WriteLine(Regex.IsMatch("asdf@microsoft.c", regex));


        }
    }
}
