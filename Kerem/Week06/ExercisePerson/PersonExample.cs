using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kerem.Week06;

namespace Kerem
{
    public class PersonExample
    {
        public static void Start()
        {
            Person p = new Person("Kerem", 23, 180, 86);
            //Console.WriteLine(p.ToString());
            Console.WriteLine(p);
            
            p.Age = 30;
            p.Name = "Würstel";
            Console.WriteLine(p);
            p.Name = "";
            Console.WriteLine(p);




        }
        
    }
}
