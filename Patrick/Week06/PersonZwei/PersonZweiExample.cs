using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.PersonOne;


namespace Patrick.Week06.PersonZwei
{
    internal class PersonZweiExample
    {
        public static void Start()
        {
            List<Person> participants = new List<Person>()
            {
                new Person("Patrick", 29, 200, 110),
                new Person("Dimitri", 32, 1.65, 80),
                new Person("Mohammed", 28, 1.85, 90)
            };
  
            Console.WriteLine("[{0}]", string.Join(", ", participants));
        }

    }
}
