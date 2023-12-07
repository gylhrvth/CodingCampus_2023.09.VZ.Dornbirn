using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Fabienne.Week10
{
    public class SQL
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=Fabienne;password=fabienne;database=mondial";

            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select * from country order by population desc", connection);

                command.Parameters.AddWithValue("@Name", "%A");
                command.Parameters.AddWithValue("@Pop", 500000);
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
            List<DbColumn> head = dataReader.GetColumnSchema().ToList();
            for (int i = 0; i < head.Count; i++)
            {
                string formatstring = string.Format("{{0, {0}}}", -1 * head[i].ColumnSize);
                if (i > 0)
                {
                    Console.Write(" | ");
                }

                Console.Write(formatstring, head[i].ColumnName);
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {

                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }
                    if (Number(dataReader[i]))
                    {
                        string formatstring = string.Format("{{0, {0}}}", Math.Max((int)head[i].ColumnSize, head[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                    }
                    else
                    {
                        string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)head[i].ColumnSize, head[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                    }
                }
                Console.WriteLine();
            }
        }
        private static bool Number(object value)
        {
            return value is int || value is double || value is float || value is decimal;
        }

       
    }
}
