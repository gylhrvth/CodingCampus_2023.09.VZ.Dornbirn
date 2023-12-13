using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Timo.Week10
{
    public class SQLUpdate
    {
        private static string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Timo;Password=Timo1234";
        public static void Start()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string city;
                do
                {
                    Console.Write("Enter the city u want to select: ");
                    city = Console.ReadLine();
                } while (!IsValidCity(connection, city));

                int amount = 0;

                while (amount == 0)
                {
                    Console.Write("How many people do u want to add to the population? ");
                    try
                    {
                        amount = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number is too high!");
                    }
                }
                SqlCommand command = new SqlCommand("update city set Population = Population + @Amount where Name = @Name", connection);

                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@Name", city);

                //int effectedRows = command.ExecuteNonQuery();
                //Console.WriteLine($"{effectedRows} rows were affected.");
                //SqlCommand cmd = new SqlCommand("select * from city where name = @City", connection);

                Console.WriteLine("Inhabitants of city \"{0}\" were updated", city);

            }
            catch (SqlException se)
            {
                switch (se.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine(se.Message + " error code: " + se.Number);
                        break;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool IsValidCity(SqlConnection conn, string city)
        {
            SqlCommand command = new SqlCommand("select * from city where name = @City", conn);
            command.Parameters.AddWithValue("@City", city);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            Console.WriteLine("\"{0}\" is not a valid city!", city);
            return false;
        }



    }
}