using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Kerem.Week10
{
    public class MySqlConnectionExample
    {
        public static void Start()
        {
            Console.Write("Welches Land möchtest du sehen? ");
            string countryName = Console.ReadLine();

            string connectionString = "server=localhost;port=3306;user=root;password=Fenerbahce1907.;database=Mondial";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.ForegroundColor = ConsoleColor.Green; // Ändere die Farbe für eine erfolgreiche Verbindung
                    Console.WriteLine("Verbindung wurde erfolgreich hergestellt.");
                    Console.ResetColor();

                    MySqlCommand command = new MySqlCommand("SELECT c.* FROM City c JOIN country co ON c.Country = co.Code WHERE co.Name = @CountryName", connection);
                    command.Parameters.AddWithValue("@CountryName", countryName);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    MySqlDataReader reader = command.ExecuteReader();

                    List<DbColumn> header = reader.GetColumnSchema().ToList();

                    // Tabellenkopf mit gelber Farbe
                    PrintTableRow(header, ConsoleColor.Blue);

                    while (reader.Read())
                    {
                        // Datenzeile mit weißer Farbe
                        PrintTableRow(reader, header, ConsoleColor.White);
                    }

                    reader.Close();
                }
                catch (MySqlException sqlE)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Ändere die Farbe für Fehler
                    Console.WriteLine("Fehler bei der MySQL-Verbindung: " + sqlE.Message);
                    Console.ResetColor();
                }
            }
        }

        private static void PrintTableRow(IEnumerable<DbColumn> columns, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (var column in columns)
            {
                string formatString = GetFormatString(column);
                Console.Write(formatString, column.ColumnName);
            }
            Console.WriteLine("|");
            Console.ResetColor();
        }

        private static void PrintTableRow(MySqlDataReader reader, IEnumerable<DbColumn> columns, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write("| ");
                string formatString = GetFormatString(columns, i);
                Console.Write(formatString, reader[i]);
            }
            Console.WriteLine("|");
            Console.ResetColor();
        }

        private static string GetFormatString(DbColumn column)
        {
            int columnSize = Math.Max((int)column.ColumnSize, (int)column.ColumnName.Length);

            if (column.DataType == typeof(string))
            {
                return $"| {{0,{-columnSize}}} ";
            }
            else if (column.DataType == typeof(float))
            {
                return $"{{0,{columnSize}}} ";
            }
            else
            {
                return $"{{0,{columnSize}}} ";
            }
        }

        private static string GetFormatString(IEnumerable<DbColumn> columns, int index)
        {
            var column = columns.ElementAt(index);
            int columnSize = Math.Max((int)column.ColumnSize, (int)column.ColumnName.Length);

            if (column.DataType == typeof(string))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                return $"{{0,{-columnSize}}} ";
            }
            else if (column.DataType == typeof(float))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                return $"{{0,{columnSize}:N2}} ";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                return $"{{0,{columnSize}}} ";
            }
        }
    }
}
