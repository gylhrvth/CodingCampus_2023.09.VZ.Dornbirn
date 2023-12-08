using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Fabian.Week10.MySQL
{
    internal class MySQLPreparedStatements
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=?Krfa2006?;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                Console.Write("What country do you want to select? ");
                string country = Console.ReadLine();


                MySqlCommand command = new MySqlCommand("select city.* from city join country c on c.Code = city.Country where c.name = @CountrySelect order by population desc;", connection);

                command.Parameters.AddWithValue("@CountrySelect", country);

                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch(MySqlException se)
            {
                switch (se.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine(se.Message);
                        break;
                }
            }
            finally
            {
                connection.Close();
            }           
        }
        public static void PrintResult(MySqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                if (header[i].DataType == typeof(string))
                {
                    string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                    Console.Write(formatstring, header[i].ColumnName);
                }
                else if (header[i].DataType == typeof(float))
                {
                    string formatstring = string.Format("{{0, {0}}}", Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                    Console.Write(formatstring, header[i].ColumnName);
                }
                else
                {
                    string formatstring = string.Format("{{0, {0}}}", Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                    Console.Write(formatstring, header[i].ColumnName);
                }
            }          
            Console.WriteLine(" |");
            Console.ResetColor();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {               
                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }
                    if (header[i].DataType == typeof(string))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                    }
                    else if (header[i].DataType == typeof(float))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string formatstring = string.Format("{{0, {0}:N2}}", Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string formatstring = string.Format("{{0, {0}}}", Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                    }
                    Console.ResetColor();
                }
                
                Console.WriteLine(" |");
            }
        }     

    }
}
