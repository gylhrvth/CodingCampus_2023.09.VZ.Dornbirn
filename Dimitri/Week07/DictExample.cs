using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dimitri.Week07
{
    internal class DictExample
    {
        public static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Dimitri", 3);

            //foreach (string name in dict.Keys)
            //{
            //    Console.WriteLine(name);
            //}

            //foreach (int value in dict.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //foreach (KeyValuePair<string, int> kvp in dict)
            //{
            //    Console.WriteLine("K:{0} V:{1}", kvp.Key, kvp.Value);
            //}

            dict.Add("Patrick", 2);


            if (dict.ContainsKey("Dimitri"))
            {
                dict["Dimitri"] = 5;
            } else
            {
                dict.Add("Dimitri", 4);
            }

            for(int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine(dict.ElementAt(i));
            }
        }
    }
}
