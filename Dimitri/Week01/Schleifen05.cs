//  ______ ________  ________ ___________ _____ 
//  |  _  \_   _|  \/  |_   _|_   _| ___ \_   _|
//  | | | | | | | .  . | | |   | | | |_/ / | |  
//  | | | | | | | |\/| | | |   | | |    /  | |  
//  | |/ / _| |_| |  | |_| |_  | | | |\ \ _| |_ 
//  |___/  \___/\_|  |_/\___/  \_/ \_| \_|\___/ 
//   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week01
{
    internal class Schleifen05
    {
        public static void Start()
        {
            for (int i = 10; i >= -10; i--)
            {
                if (i % 2 == 0)
                {
                Console.WriteLine($"i: {i}");
                }
            }
        }
    }
}
