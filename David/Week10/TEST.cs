using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace David.Week10
{
    public class TEST
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=david;pwd=david;database=mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                connection.Open();
                Console.WriteLine("Verbindung....");

                MySqlCommand command = new MySqlCommand("SELECT l.Name, ROUND(sum(c.Population * l.Percentage / 100)) AS totalSP\n\tFROM `language` l " +
                    "\n\tJOIN country c on c.Code = l.Country\n\tGROUP BY l.Name\n\tORDER BY totalSP DESC LIMIT 10;", connection);

                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public static void PrintResult(MySqlDataReader dataReader) 
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write("|");
                }
                int width = Math.Max(12, header[i].ColumnName.Length);
                if (header[i].DataType.Name == "String" && header[i].ColumnSize != null)
                {
                    width = -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                }
                string formatstring = string.Format("{{0,{0}}}", width);
                Console.Write(formatstring, header[i].ColumnName);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("|");
                    }
                    int width = Math.Max(12, header[i].ColumnName.Length);
                    string formatString = string.Format("{{0,{0}}}", width);
                    if (header[i].DataType.Name == "String" && header[i].ColumnSize != null)
                    {
                        width = -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                        formatString = string.Format("{{0,{0}}}", width);
                    }
                    else if (header[i].DataType.Name == "Single")
                    {
                        width = Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                        formatString = string.Format("{{0,{0}:N2}}", width);
                    }
                    Console.Write(formatString, dataReader[i]);
                }
                Console.WriteLine();
            }
        }
    }
}

