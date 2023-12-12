using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.Nist;

namespace David.Week04.Udemy
{
    public class uebung3
    {
        public static void Start()
        {
            List<string> names = new List<string>()
            {
                "David ","Camilo","José  "
            };
            List<int> nc = new List<int>()
            {
                4,3,2
            };

            foreach (var student in names)
            {
                Console.Write(student + " | ");
            }
            Console.WriteLine();
            foreach (var note in nc)
            {
                Console.Write(note + "      | ");
            }
            Console.WriteLine();

            NumClaus(nc);
        }

        public static void NumClaus(List<int> nc)
        {
            int count = 0;
            int sum = 0;

            foreach (int num in nc)
            {
                count++;
                sum = (num + sum);
            }

            Console.WriteLine("Durchschnittsnote ist: " + (sum / count));
            Console.WriteLine(sum);
        }
    }
}

