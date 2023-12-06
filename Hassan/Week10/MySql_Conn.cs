using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Hassan.Week10
{
    public class MySql_Conn
    {
        public static void Start()
        {
            string connentionString = "server=localhost;port=3306;user=root;password=Hassan.1407;database=Mondial";
            MySqlConnection conn = new MySqlConnection(connentionString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", conn);

                command.Parameters.AddWithValue("@Name", "%on");
                command.Parameters.AddWithValue("@Pop", 1000000);
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
                conn.Close();
            }

        }

        public static void PrintResult(MySqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            // Drucke die Spaltenüberschriften
            foreach (DbColumn column in header)
            {
                Console.Write($"{column.ColumnName,-15} | "); // -15 sorgt für eine festgelegte Breite der Spalten
            }
            Console.WriteLine();
          
            Console.WriteLine();

            // Drucke die Daten
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    string value = dataReader[i].ToString();
                    if (header[i].DataType == typeof(int) || header[i].DataType == typeof(float))
                    {
                        Console.Write($"{value,15} | "); // Rechtsbündig für FLOAT-Datentypen
                    }
                    else
                    {
                        Console.Write($"{value,-15} | "); // -15 für eine festgelegte Breite der Spalten
                    }
                }
                Console.WriteLine();
            }
        }



    }
}
