using System.Data.Common;
using System.Data.SqlClient;

namespace Jovo.Week11
{
    internal class SQLTEST
    {
        public static void Start()
        {


            SqlConnection sqlConnection = new SqlConnection(ConnectionString());
            Console.WriteLine("Which City do you wanna see?");
            string userinput = Console.ReadLine();
            SqlCommand sqlcmd = new SqlCommand("SELECT c.name, c.population FROM City c   Where c.Name = @userinput", sqlConnection);

            sqlcmd.Parameters.AddWithValue("@userinput", userinput);


            try
            {
                sqlcmd.Connection.Open();
                using (SqlDataReader reader = sqlcmd.ExecuteReader())
                {
                  
                    Console.WriteLine("\n");
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i] + "     |     ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();



                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("funktioniert nicht");
            }
            finally
            {
                sqlConnection.Close();
            }

            Console.WriteLine("do you wanna add some population? y = yes/ n = no");
            string userinput2 = Console.ReadLine();

            if (userinput2 == "y")
            {

                Console.WriteLine("how much should i add");
                string userinput3 = Console.ReadLine();
                SqlCommand sqlcmd2 = new SqlCommand("UPDATE city SET Population = Population + @userinput3\r\n--WHERE NAME = @userinput", sqlConnection);
                sqlcmd2.Parameters.AddWithValue("@userinput3", userinput3);
                Console.WriteLine("Population was added ");

                sqlcmd2.Connection.Open();
                SqlDataReader reader = sqlcmd2.ExecuteReader();
                reader.Close();
                sqlcmd2.Connection.Close();
                

                try
                {
                    sqlcmd.Connection.Open();

                    using (SqlDataReader reader2 = sqlcmd.ExecuteReader())
                    {
                        Console.WriteLine();
                        while (reader2.Read())
                        {
                            for (int i = 0; i < reader2.FieldCount; i++)
                            {
                                Console.Write(reader2[i] + "     |     ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
            public static string ConnectionString()
            {
                return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Jovo;Password=jovo13696";
            }
        
    }
}

