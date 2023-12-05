using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace Gheorghe.Week10
{
    public class MSSQL_ConnectExample
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=gheorghe;Password=Eldad100";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select c.*\nfrom City c \njoin country co on c.Country =co.Code \nwhere co.Name = 'Austria' ", connection);

                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder stringBuilder = new StringBuilder();

                        // Build the table header
                        stringBuilder.AppendLine(String.Format("{0,-20} | {1,-10} | {2,-10} | {3,-12} | {4,-10} | {5,-10} | {6,-10}", "Name", "Country", "Province", "Population", "Latitude", "Longitude", "Elevation"));
                        stringBuilder.AppendLine("-------------------------------|------------|------------|-------------|------------|------------|------------");

                        // Build the table rows
                        while (reader.Read())
                        {
                            string row = "";

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value = reader[i].ToString();

                                if (value == "")
                                {
                                    value = "NULL";
                                }

                                // Check data type to align left or right
                                if (ValueType(value) == typeof(string) || ValueType(value) == typeof(DateTime))
                                {
                                    row += String.Format("{0,-20} | ", value);
                                }
                                else
                                {
                                    row += String.Format("{0,-12} | ", value);
                                }
                            }

                            stringBuilder.AppendLine(row.TrimEnd(' '));
                        }

                        // Print the table
                        Console.WriteLine(stringBuilder.ToString());
                    }
                }
                catch (SqlException sqlE)
                {
                    Console.WriteLine(sqlE.Message);
                }
            }
        }

        private static Type ValueType(object obj)
        {
            if (obj == null)
            {
                return obj.GetType();
            }

            if (obj is DBNull)
            {
                return typeof(DBNull);
            }

            return obj.GetType();
        }
    }
}




