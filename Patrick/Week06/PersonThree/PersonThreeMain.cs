using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrick.Week06.PersonOne;

namespace Patrick.Week06.PersonThree
{
    public class PersonThreeMain
    {
        public static void Start()
        {
            CourseGroup seoBootCamp = new CourseGroup("SEO & SEA Bootcamp");
            seoBootCamp.addAllPerson(new List<Person>
            {
                new Person("Patrick", 29, 200f, 110),
                new Person("Dimitri", 32, 165f, 80),
                new Person("Mohammed", 28, 185f, 90),
                new Person("Richard", 45, 172f, 73),
                new Person("David", 35, 176f, 60)
            });


            Person getMaxAge = seoBootCamp.GetMaxAge();
            Console.WriteLine("Der älteste Teilnehmer ist : {0} und er ist {1} Jahre alt", getMaxAge.Name, getMaxAge.Weight);

            Person getMinAge = seoBootCamp.GetMinAge();
            Console.WriteLine("Der jüngste Teilnehmer ist : {0} und er ist {1} Kg Jahre alt", getMinAge.Name, getMinAge.Weight);

            Person getMaxHeight = seoBootCamp.GetMaxHeight();
            Console.WriteLine("Der größte Teilnehmer ist : {0} und er ist {1} cm groß", getMaxHeight.Name, getMaxHeight.Weight);

            Person getMinHeight = seoBootCamp.GetMinHeight();
            Console.WriteLine("Der kleinste Teilnehmer ist : {0} und er ist {1} cm groß", getMinHeight.Name, getMinHeight.Weight);

            Person getMaxWeight = seoBootCamp.GetMaxWeight();
            Console.WriteLine("Der schwerste Teilnehmer ist : {0} und er ist {1} Kg schwer", getMaxWeight.Name, getMaxWeight.Weight);

            Person getMinWeight = seoBootCamp.GetMinWeight();
            Console.WriteLine("Der leichteste Teilnehmer ist : {0} und er ist {1} Kg schwer", getMinWeight.Name, getMinWeight.Weight);

            //Sortiert nach Alter aufsteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach dem Alter aufsteigend");
            Console.ResetColor();
            seoBootCamp.SortByAgeUp();
            seoBootCamp.PrintAllPersons();
           
            //Sortiert nach Alter absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach dem Alter absteigend");
            Console.ResetColor();
            seoBootCamp.SortByAgeDown();
            seoBootCamp.PrintAllPersons();

            //Sortiert nach der Größe aufsteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach der Größe aufsteigend");
            Console.ResetColor();
            seoBootCamp.SortByHeightUp();
            seoBootCamp.PrintAllPersons();

            //Sortiert nach der Größe absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach der Größe absteigend");
            Console.ResetColor();
            seoBootCamp.SortByHeightDown();
            seoBootCamp.PrintAllPersons();

            //Sortiert nach dem Gewicht aufsteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach dem Gewicht aufsteigend");
            Console.ResetColor();
            seoBootCamp.SortByWeightUp();
            seoBootCamp.PrintAllPersons();

            //Sortiert nach dem Gewicht absteigend
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sortiert nach dem Gewicht absteigend");
            Console.ResetColor();
            seoBootCamp.SortByWeightDown();
            seoBootCamp.PrintAllPersons();
        }


        
    }
}
