using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Erik.Week05
{
    public class CheckEmailRegex
    {
        public static void Start()
        {

            UserInputCheck();
        }

        public static void UserInputCheck()
        {
            String regex = @"^[aA-zZ]([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Console.WriteLine(Regex.IsMatch("alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina.alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("rambina1.1alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("1rambina1.alfons@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("@drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("drlue.at", regex));
            Console.WriteLine(Regex.IsMatch("asdf@drlue", regex));
            Console.WriteLine(Regex.IsMatch("asdf@microsoft.c", regex));
        }
    }
}
