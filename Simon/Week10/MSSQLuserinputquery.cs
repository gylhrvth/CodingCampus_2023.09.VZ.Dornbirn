using Simon.Week03;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Simon.Week10
{
    public class MSSQLuserinputquery
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=simber;Password=simon1234";
            Console.WriteLine("Select the City you would like to add Population to:");
            string userinput = Console.ReadLine();

            int userinputint = Console_Input.Readuserinputint("By how much would you like to increace the Population?", "Please only use numbers!", int.MinValue, int.MaxValue);

            addpoptoDatabase(userinput, userinputint, connectionString);



        }

        public static void addpoptoDatabase(string userinput, int userinputint, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from city c where c.name = @Name", conn)) 
                {
                    cmd.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 0).Value = userinput;

                    try
                    {
                        cmd.Connection.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                SqlString GetSqlString = dataReader.GetSqlString(0);
                                dataReader.Close();
                                Console.WriteLine($"The City {GetSqlString} was found.");

                                using (SqlCommand cmd1 = new SqlCommand("update city set population = population + @population where city.name = @Name", conn))
                                {
                                    cmd1.Parameters.Add("@population", System.Data.SqlDbType.Int).Value = userinputint;
                                    cmd1.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 0).Value = userinput;
                                    cmd1.ExecuteReader();
                                    Console.WriteLine($"{userinputint} was added to the current Population");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{userinput} was not found in the Database.");
                                // run me again
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }            
            }
        }

        public static void IsinDatabase(string userinput)
        {
            SqlString GetSqlString;

        }

        public static void test()
        {
            string connectionString = "your_connection_string_here";
            string queryString = "SELECT YourColumn FROM YourTable WHERE YourColumn = @SearchValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    // Set the parameter for the SQL query
                    command.Parameters.AddWithValue("@SearchValue", "YourSpecificString");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The string is in the database
                            SqlString sqlString = reader.GetSqlString(0);
                            Console.WriteLine($"Found: {sqlString.Value}");
                        }
                        else
                        {
                            // The string is not in the database
                            Console.WriteLine("String not found in the database.");
                        }
                    }
                }
            }
        }



    }
}
