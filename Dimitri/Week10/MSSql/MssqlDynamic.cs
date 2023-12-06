using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.MSSql
{
    internal class MssqlDynamic
    {
        public static void Main()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            string query = "SELECT * FROM river";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Determine maximum column widths
                        int[] columnWidths = new int[reader.FieldCount];

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                int length = reader[i].ToString().Length;
                                columnWidths[i] = Math.Max(columnWidths[i], length);
                            }
                        }

                        // Print headers
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string formatstring = string.Format("{{0,{0}}}", -columnWidths[i]);
                            Console.Write(formatstring, reader.GetName(i));
                        }
                        Console.WriteLine();

                        // Print data
                        //reader.Close(); // Reset reader to the beginning
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string formatstring = string.Format("{{0,{0}}}", -columnWidths[i]);
                                Console.Write(formatstring, reader[i]);
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }

}
