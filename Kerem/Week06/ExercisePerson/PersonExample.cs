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
            Console.WriteLine(p.ToString());
            p.Age = 30;
            


        }
        
    }
}
