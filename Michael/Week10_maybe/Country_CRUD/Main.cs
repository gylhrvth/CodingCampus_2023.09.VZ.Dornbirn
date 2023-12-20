using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week10_maybe.Country_CRUD
{
    internal class Main
    {
        public static void Start()
        {
            DataBase dataBase = new DataBase(GetConnectionString());
            dataBase.Connect();

            Console.WriteLine("EXISTENCE TEST:");
            Console.WriteLine("austria exists: " + dataBase.Exists("Austria"));
            Console.WriteLine();

            Console.WriteLine("FIND AUSTRIA:");
            List<Country> austrias = dataBase.Find("Austria");
            PrintCountryList(austrias);
            Console.WriteLine();

            Console.WriteLine("DELETE AUSTRIA:");
            dataBase.Delete("Austria");

            PrintCountryList(dataBase.Find("Austria"));
            Console.WriteLine();

            Console.WriteLine("EXISTENCE TEST:");
            Console.WriteLine("austria exists: " + dataBase.Exists("Austria"));
            Console.WriteLine();

            Console.WriteLine("CREATE AUSTRIA:");
            dataBase.Create(austrias[0]);

            PrintCountryList(dataBase.Find("Austria"));
            Console.WriteLine();

            Console.WriteLine("CHANGE AUSTRIA:");
            austrias[0]._code = "ÄÄÄÄ";
            dataBase.Update("Austria", austrias[0]);

            PrintCountryList(dataBase.Find("Austria"));
            Console.WriteLine();

            Console.WriteLine("CHANGE AUSTRIA:");
            austrias[0]._code = "A";
            dataBase.Update("Austria", austrias[0]);

            PrintCountryList(dataBase.Find("Austria"));
            Console.WriteLine();

            List<Country> countries = dataBase.Find2<Country>(new System.Data.SqlClient.SqlCommand("select name, code, capital, area, population from country"));

            foreach(Country country in countries)
            {
                Console.WriteLine("Name: " + country._name);
            }



            List<City> cities = dataBase.Find2<City>(new System.Data.SqlClient.SqlCommand("select name from city"));

            foreach (City city in cities)
            {
                Console.WriteLine("Name: " + city._name);
            }

        }

        public static string GetConnectionString()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:192.168.0.77,1433;User=Michael;Password=Michael";
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Michael Hämmerle;Password=Kyan2003*";
        }


        public static void PrintCountryList(List<Country> list)
        {
            Console.WriteLine($"{"Name",-15} | {"Code",-4} | {"Capital",-15} | {"Area",10} | {"Population",10}");
            Console.WriteLine("-+-".PadLeft(15+3, '-') + "-+-".PadLeft(4+3, '-') + "-+-".PadLeft(15+3, '-') + "-+-".PadLeft(10+3, '-') + "".PadLeft(10, '-'));

            foreach (Country country in list)
            {
                Console.WriteLine($"{country._name, -15} | {country._code, -4} | {country._capital, -15} | {country._area, 10} | {country._population, 10}");
            }
        }
    }
}
