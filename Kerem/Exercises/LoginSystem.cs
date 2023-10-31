using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class LoginSystem
    {
        static string username;
        static string password;

        public static void LoginSystemStart()
        {
            Register();
            Login();
            Console.Read();

        }
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("-----------------------");

        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login succesfull");
                }
                else
                {
                    Console.WriteLine("Login failed, wrong password. Restart Program");
                }

            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart Program");
            }




        }
    }
}
