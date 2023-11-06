using Martin.Week06.Person;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06
{
    public class Liste
    {

        public static void Start()
        {

            List<int> Inventar = CreateList(0, 99, 5);
            List<int> Inventar2 = CreateList(0, 99, 10);

            SotierenAbsteigend(Inventar);
            SotierenAbsteigend(Inventar2);

            //List<int> NeueListe = ZählenVonGeradenZahlen(Inventar);
            //ZählenVonGeradenZahlen(Inventar);
            //SotierenAbsteigend(NeueListe);

            //KleinstenZahlSuchen(Inventar);
            //GrößteZahlSuchen(Inventar);

            List<int> OrginalListe = ListZusammenführen(Inventar, Inventar2);
            //SotierenAbsteigend(OrginalListe);

            PrintList(OrginalListe);
            //Person20();
        }

        public static List<int> CreateList(int min, int max, int size)
        {
            Random rand = new Random();
            List<int> Inventar = new List<int>();

            for (int i = 0; i < size; i++)
            {
                Inventar.Add(rand.Next(min, max));
            }
            return Inventar;
        }

        public static void PrintList(List<int> list)
        {

            Console.WriteLine("[{0}]", string.Join(", ", list));
            
        }

        public static List<int> ZählenVonGeradenZahlen(List<int> Inventar)
        {
            int anzahldergeradenZahlen = 0;

            for(int i = 0; i < Inventar.Count;i++)
            {

                if (Inventar[i] % 2 == 0)
                {
                    anzahldergeradenZahlen++;
                    Console.WriteLine(Inventar[i] + "ist eine gerade Zahl");
                }
                else
                {
                    Inventar.RemoveAt(i);
                    i--;                    //i-- zum der Index zu löschen
                }
                    

                //Console.WriteLine(Inventar[i] + ": stelle" + i);
            }

            Console.WriteLine("Es gibt: {0} zahlen die gerade sind", anzahldergeradenZahlen);

            return Inventar;

           
        }

        public static int KleinstenZahlSuchen(List<int> Inventar)
        {
           
            int Min = Int32.MaxValue;


            for(int i = 0; i < Inventar.Count; i++)
            {
                if (Inventar[i] < Min) // checken ob die randomzahl kleiner ist als das minium wenn ja ist sie das neue min
                {
                    Min = Inventar[i];
                }
            }

            Console.WriteLine("Die kleinste Zahl ist: {0}",Min);
            return Min;
        }

        public static int GrößteZahlSuchen(List<int> Inventar)
        {

            int Max = Int32.MinValue;

            for (int i = 0; i < Inventar.Count; i++)
            {
                if (Inventar[i] > Max)
                {
                    Max = Inventar[i];
                }
            }

            Console.WriteLine("Die größte Zahl ist: {0}", Max);

            return Max;
        }

        public static void SotierenAbsteigend(List<int> Inventar)
        {
            for(int i = 0; i < Inventar.Count; i++)
            {

                for (int j = 0; j < Inventar.Count - 1; j++)
                {

                    if (Inventar[j] < Inventar[j + 1])
                    {
                        int Savenumber = Inventar[j];

                        Inventar[j] = Inventar[j + 1];

                        Inventar[j + 1] = Savenumber;
                    }

                }

            }

        }

        public static List<int> ListZusammenführen(List<int> list1, List<int> liste2)
        {
            List<int> OrginalList = new List<int>();

            int i1 = 0;
            int i2 = 0;

            while(i1 < list1.Count && i2 < liste2.Count)
            {
                if (list1[i1] < liste2[i2])
                {
                    OrginalList.Add(liste2[i2]);
                    i2++;
                }
                else
                {
                    OrginalList.Add(list1[i1]);
                    i1++;
                }
            }

            while(i1 < list1.Count)
            {
                OrginalList.Add(list1[i1]);
                i1++;
            }

            while (i2 < liste2.Count)
            {
                OrginalList.Add(liste2[i2]);
                i2++;
            }
            return OrginalList;
        }
        public static List<PersonAufgabe> Person20()
        {
            List<PersonAufgabe> Personen = new List<PersonAufgabe>();

            PersonAufgabe person = new PersonAufgabe(150, 12, "Martin", 23);
            PersonAufgabe person2 = new PersonAufgabe(1320, 22, "lukas", 23);
            Personen.Add(person);

            for(int i = 0; i < Personen.Count - 1; i++)
            {
                if (Personen[i].Groesse > Personen[i + 1].Groesse)
                {
                    Console.WriteLine(Personen[i].Name + "ist grösser als" + Personen[i + 1].Name);
                }
            }        
            return Personen;
        }
    }
}
