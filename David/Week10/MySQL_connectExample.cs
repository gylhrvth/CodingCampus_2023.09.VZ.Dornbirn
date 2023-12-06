using System;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace David.Week10
{
    public class MySQL_connectExample
    {
        public static void Start()
        {


            string connectionString = "server=localhost;port=3306;user=david;password=david;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                connection.Open();
                Console.WriteLine("Welches Land möchtest du sehen? ");
                string land = Console.ReadLine();
                MySqlCommand command = new MySqlCommand("select c.* \nfrom City c \njoin country co on c.Country = co.Code \nwhere co.Name = @LandSelect", connection);
                command.Parameters.AddWithValue("@LandSelect", land);

                Console.WriteLine("Verbindung wurde aufgebaut.");
                Console.ForegroundColor = ConsoleColor.Blue;
                MySqlDataReader reader = command.ExecuteReader();

                List<DbColumn> header = reader.GetColumnSchema().ToList();
                for (int i = 0; i < header.Count; i++)
                {
                    if (header[i].DataTypeName == "nvarchar")
                    {
                        string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, header[i].ColumnName);
                    }
                    else if (header[i].DataTypeName == "float")
                    {
                        Console.Write("| {0,20:N2} ", header[i].ColumnName);
                    }
                    else
                    {
                        Console.Write("| {0,20} ", header[i].ColumnName);
                    }
                }
                Console.WriteLine("|");
                Console.ResetColor();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write("| ");
                        if (header[i].DataTypeName == "nvarchar")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                            Console.Write(formatString, reader[i]);
                        }
                        else if (header[i].DataTypeName == "float")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0,20:N2} ", reader[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("{0,20} ", reader[i]);
                        }
                        Console.ResetColor();
                    }
                    Console.WriteLine("|");
                }
                reader.Close();
            }
            catch (MySqlException sqlE)
            {
                Console.WriteLine(sqlE.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
