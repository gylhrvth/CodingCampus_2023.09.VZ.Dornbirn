using Martin.Week06.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06
{
    public class Person2
    {
        public static void Start()
        {
   
            List<PersonAufgabe> AllPersons = CreatePeopleList();

            //List<PersonAufgabe> TallestHeight = CalculateTallestPerson(AllPersons);
            //List<PersonAufgabe> SmallestHeight = CalculateSmallestPerson(AllPersons);

            //List<PersonAufgabe> OldestPerson = CalculateOldestPerson(AllPersons);
            //List<PersonAufgabe> YoungestPerson = CalculateYoungestPerson(AllPersons);

            //List<PersonAufgabe> ThinestPerson = CalculateThinestPerson(AllPersons);
            List<PersonAufgabe> HeavstPerson = CalculateHeavestPerson(AllPersons);
        }

        public static List<PersonAufgabe> CreatePeopleList()
        {
            PersonAufgabe PersonMartin = new PersonAufgabe(180, 23, "Martin", 89);
            PersonAufgabe PersonLukas = new PersonAufgabe(132, 3331, "Lukas", 120);
            PersonAufgabe PersonDaria = new PersonAufgabe(122, 311, "Daria", 13);
            PersonAufgabe PersonRiese = new PersonAufgabe(1331, 332, "Riese", 123333);

            List<PersonAufgabe> AllPersons = new List<PersonAufgabe>();
            AllPersons.Add(PersonMartin);
            AllPersons.Add(PersonLukas);
            AllPersons.Add(PersonDaria);
            AllPersons.Add(PersonRiese);

            return AllPersons;

        }

        public static List<PersonAufgabe> CalculateTallestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Maximum = Int32.MinValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Groesse > Maximum)
                {
                    Maximum = AllPersons[i].Groesse;
                }
                
            }

            Console.WriteLine(Maximum + " ist der grösse von dieser Liste");


            return AllPersonsHeight;

        }
        public static List<PersonAufgabe> CalculateSmallestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Min = Int32.MaxValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Groesse < Min)
                {
                    Min = AllPersons[i].Groesse;
                }

            }

            Console.WriteLine(Min + " ist der kleinste von dieser Liste");


            return AllPersonsHeight;

        }
        public static List<PersonAufgabe> CalculateOldestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Min = Int32.MinValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Alter > Min)
                {
                    Min = AllPersons[i].Alter;
                }

            }

            Console.WriteLine(Min + " ist der älteste von dieser Liste");


            return AllPersonsHeight;

        }
        public static List<PersonAufgabe> CalculateYoungestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Min = Int32.MaxValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Alter < Min)
                {
                    Min = AllPersons[i].Alter;
                }

            }

            Console.WriteLine(Min + " ist der jüngste von dieser Liste");


            return AllPersonsHeight;

        }

        public static List<PersonAufgabe> CalculateThinestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Min = Int32.MaxValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Gewicht < Min)
                {
                    Min = AllPersons[i].Gewicht;
                }

            }

            Console.WriteLine(Min + " ist der leichteste von dieser Liste");


            return AllPersonsHeight;

        }

        public static List<PersonAufgabe> CalculateHeavestPerson(List<PersonAufgabe> AllPersons)
        {
            List<PersonAufgabe> AllPersonsHeight = new List<PersonAufgabe>();

            int Min = Int32.MinValue;

            for (int i = 0; i < AllPersons.Count; i++)
            {

                if (AllPersons[i].Gewicht > Min)
                {
                    Min = AllPersons[i].Gewicht;
                }

            }

            Console.WriteLine(Min + " ist der schwerste von dieser Liste");


            return AllPersonsHeight;

        }


        public static void PrintList(List<PersonAufgabe> Liste)
        {
            foreach(PersonAufgabe Person in Liste)
            {
                Console.WriteLine(Person);
            }
        }

    }
}
