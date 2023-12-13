using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Selina.Week10.Aufgabe_03
{
    public class MainDatabase
    {
        public static void Start()
        {
            string morePopulation;
            string again;
            Console.OutputEncoding = Encoding.UTF8;
            string connenctionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localHost,1433;user=selina;password=selina";
            Database database = new Database(connenctionString);

            do
            {
                SqlCommand cmd = new SqlCommand("select Name as CityName, Country as Land , Province as Hauptstadt , Population as Einwohner \nfrom city where \nName like @Name");
                database.Connect();
                UserOutput(database);

                try
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    database.Print(dataReader);
                    database.Disconnect();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                again = ReadText("\nMöchtest du nochmal etwas ändern? (Y/N) ", "Das ist kein Text! VERSUCHE ES NOCHMAL! ");
            } while (again.ToLower() == "y");
        }

        public static void UserOutput(Database database)
        {
            Country country = new Country();
            float userInput = ReadNumber(" Was möchtest du machen? \n\n 1. Ein neues Land hinzufügen?    🗺️\n 2. Ein bestimmtes Land in der Datenbank finden? 🔏\n 3. Ein bestimmtes Attribut eines Landes ändern?  🌍\n" +
                         " 4. Ein bestimmtes Land aus der Datenbank löschen? 🗑️    ", "Du musst ein Text eingeben!    😡");

            if (userInput == 1)
            {
                Console.Write("\n\t --> Wie soll ihr Land heißen?   ");
                country.Name = Console.ReadLine();
                if (database.CityIsInTheQuery(country.Name))
                {
                    Console.WriteLine("Diese Stadt gibt es schon!!");
                }
                else
                {
                    database.CreateCountry(country);
                }
            }
        }
        public static string ReadText(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    string cityName = Convert.ToString(Console.ReadLine());
                    cityName.ToUpper();

                    return cityName;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
        public static float ReadNumber(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    float number = Convert.ToSingle(Console.ReadLine());
                    return number;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
    }
}

