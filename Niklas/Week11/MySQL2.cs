using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Niklas.Week11
{
    internal class MySQL2
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a city: ");
            string city = Console.ReadLine();

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string connectionstring = "server=localhost;user=Niklas;password=6C#fw,_.UDbLa&g;port=3306;database=Mondial";

            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                using (MySqlCommand updateCommand = new MySqlCommand("UPDATE City SET population = population + @number where name = @Cityselect", connection))
                {
                    updateCommand.Parameters.AddWithValue("@Cityselect", city);
                    updateCommand.Parameters.AddWithValue("@number", number);
                    int numRowsUpdated = updateCommand.ExecuteNonQuery();
                }

                using (MySqlCommand selectCommand = new MySqlCommand("SELECT c.* FROM City c JOIN country co ON c.Country = co.Code WHERE c.Name = @Cityselect", connection))
                {
                    selectCommand.Parameters.AddWithValue("@Cityselect", city);

                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();

                        while (reader.Read())
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < header.Count; i++)
                            {
                                string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                Console.Write(formatString, header[i].ColumnName);
                            }
                            Console.WriteLine();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                Console.Write(formatString, reader[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                }

                if (Console.ForegroundColor != ConsoleColor.Cyan)
                {
                    Console.WriteLine("City does not exist!");
                }

                using (MySqlCommand resetCommand = new MySqlCommand("UPDATE City SET population = population - @number where name = @Cityselect", connection))
                {
                    resetCommand.Parameters.AddWithValue("@Cityselect", city);
                    resetCommand.Parameters.AddWithValue("@number", number);
                    int numRowsUpdated = resetCommand.ExecuteNonQuery();
                }

                connection.Close();
                Console.ResetColor();
            }
        }
    }
}
