using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Jovo.Week06
{
    public class ListeErstellen
    {

        private static Random rand = new Random();
        public static void Start()
        {

            List<int> values = new List<int>();
            

            for(int i = 0; i < 20; i++) 
            {
                values.Add(rand.Next(0,99));
            }

            Console.WriteLine("Count: {0}",values.Count);
            Console.WriteLine("Capacity: {0}",values.Capacity);




        }

      

    }

}
