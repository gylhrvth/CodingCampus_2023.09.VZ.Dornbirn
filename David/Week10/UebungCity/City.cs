using System;
using System.Data.Common;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace David.Week10.UebungCity
{
    public class City
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=david;pwd=david;database=mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);


            try
            {
                connection.Open();
                Console.WriteLine("Connected.");

                Console.WriteLine("Type in a City name of your choice:");
                string citySelect = Console.ReadLine();

                MySqlCommand command = new MySqlCommand("SELECT c.Name, c.Population from city c \nWHERE c.Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", citySelect);

                MySqlDataReader dataReader = command.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    Console.WriteLine("Sorry the city is'nt in the database!");
                }

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


            try
            {
                connection.Open();
                Console.WriteLine("Connected.");

                Console.WriteLine("Bitte füge neue Bewohner der Stadt hinzu:");
                string numberPeople = Console.ReadLine();

                MySqlCommand command = new MySqlCommand("UPDATE city SET Population = Population + @Number WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Number", numberPeople);

                MySqlDataReader dataReader = command.ExecuteReader();

                if (!dataReader.HasRows)
                {
                    Console.WriteLine("Sorry the city is'nt in the database!");
                }

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


