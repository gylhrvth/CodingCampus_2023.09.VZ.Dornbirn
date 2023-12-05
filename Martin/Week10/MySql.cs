using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Martin.Week10
{
    public class MySql
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=Martin;password=HoffNd;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

                command.Parameters.AddWithValue("@Name", "%on");
                command.Parameters.AddWithValue("@Pop", 1000);
                MySqlDataReader dataReader = command.ExecuteReader();


                PrintResult(dataReader);
                dataReader.Close();
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
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


    }
}
