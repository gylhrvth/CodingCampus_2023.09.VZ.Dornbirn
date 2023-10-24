using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week05
{
    public class StringCompare
    {

        public static void Start()
        {

            //????????????????????

            Console.WriteLine("Geben Sie String 1 ein:");
            string word =Console.ReadLine();

            Console.WriteLine("Geben Sie String 2 ein:");
            string word2 =Console.ReadLine();



            
            Console.WriteLine("==     : " + (word == word2));
            Console.WriteLine("Equals : " + (word.Equals(word2)));





        }



    }
}
