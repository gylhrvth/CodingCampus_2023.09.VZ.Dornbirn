using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Niklas.Week06.Person
{
    internal class PersonExample
    {
        public static string Start()
        {
            Person2 p1 = new Person2(0, 0, "Person", 0);
            //Console.WriteLine(p1);
            //Console.WriteLine("____________________");

            //Console.Write("Enter your age: ");
            p1.Age = /*Convert.ToInt32(Console.ReadLine()*/ 44;
            ////Console.Write("Enter your name: ");
            p1.Name = /*Convert.ToString(Console.ReadLine()*/"Guyla";
            ////Console.Write("Enter your height: ");
            //p1.Size = /*Convert.ToInt32(Console.ReadLine()*/ 175;
            ////Console.Write("Enter your weight: ");
            //p1.Weight = /*Convert.ToInt32(Console.ReadLine()*/75;
            //Console.WriteLine("______________________");
            //Console.WriteLine(p1);
            //Console.WriteLine("Weight: " + p1.Weight);
            //Console.WriteLine("Size: " + p1.Size);
            return Convert.ToString(p1);
        }
    }
}