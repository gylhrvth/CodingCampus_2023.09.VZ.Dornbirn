using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Martin.Week10
{
    public class MySqlUpdate
    {
        public static void Start()
        {

            int AddNumber = 0;
            string city = "";

            string connectionString = "server=localhost;port=3306;user=Martin;pwd=NiceTry;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                city = AskForCity(connection);
                AddNumber = AskForNumber(); //Für die Anzahl fragen die, dazu gezählt werden.

                MySqlCommand AddNumbersCommand = new MySqlCommand("update city set Population = Population + @AddNumber where Name = @City", connection);

                AddNumbersCommand.Parameters.AddWithValue("@AddNumber", AddNumber);
                AddNumbersCommand.Parameters.AddWithValue("@City", city);


                MySqlDataReader reader2 = AddNumbersCommand.ExecuteReader();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Updated");
                Console.ForegroundColor = ConsoleColor.White;

                reader2.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void PrintResult(MySqlDataReader dataReader)
        {

            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            // nimm die columns z.B hat City und hat Country,Name..usw und macht dann eine liste daraus

            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write($"|");
                }
                string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                Console.Write(formatstring, header[i].ColumnName);
            }
            Console.WriteLine("|");


            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write("|");
                    }

                    if (dataReader.GetDataTypeName(i) == "VARCHAR")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string formatstring = string.Format("{{0, {0}}}", +1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("|");
            }
        }

        public static int AskForNumber()
        {
            int newNumber = 0;

            while (newNumber == 0)
            {

                try
                {
                    Console.WriteLine("How much Population do you wana add?");
                    newNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a Number!");
                }
            }

            return newNumber;
        }

        public static string AskForCity(MySqlConnection connection)
        {
            string City = "";
            bool cityfound = false;

            while (cityfound == false)
            {
                Console.WriteLine("Which city do you want to add population to?");
                City = Console.ReadLine();

                MySqlCommand command = new MySqlCommand("select * from city where name like @City", connection);

                command.Parameters.AddWithValue("@City", City);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // überprüft ob diese Stadt gibt
                {

                    cityfound = true;
                    PrintResult(reader);
                    Thread.Sleep(2000);
                    Console.Clear();
                    reader.Close();
                }
                else
                {
                    Console.WriteLine("the city is not found");
                    break;
                }

            }

            return City;
        }
    }
}
