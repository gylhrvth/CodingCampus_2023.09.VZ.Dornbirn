using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06
{
    public class EnumExample
    {
        public enum Pets
        {
            Dog,
            Cat,
            Parrot,
            Horse,
            Bird,
            Hamster
        }

        public static void Start()
        {
            Random rand = new Random();

            int[] petsIndex = new int[6];

            Pets p = Pets.Dog;

            for (int i = 0; i < petsIndex.Length; i++)
            {
                Console.WriteLine(p + "Pet");

              
                p++;
            }

        }

    }
}
