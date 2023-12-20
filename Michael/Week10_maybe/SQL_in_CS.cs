using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Michael.Week10_maybe
{
    internal class SQL_in_CS
    {
        public static void Start()
        {
            AdjustPopulation();
        }


        public static void AdjustPopulation()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                string code = "";
                bool neededCountry = false;
                string wannaGoAgain = "y";
                while(wannaGoAgain == "y" || wannaGoAgain == "yes")
                {
                    SqlCommand command = new SqlCommand();
                    string city = "";

                    //ask for city and show data
                    int results = 0;
                    while (results != 1)
                    {
                        command = new SqlCommand("Select country, name, population FROM city WHERE name = @Name", connection);
                        neededCountry = false;
                        results = 0;
                        city = AskForCity();
                        Console.Clear();

                        command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = city;

                        try
                        {
                            command.Connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                bool foundSomething = false;
                                while (reader.Read())
                                {
                                    foundSomething = true;
                                    ++results;
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.Write(reader[i] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                if (foundSomething) Console.WriteLine();
                            }
                            command.Connection.Close();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        Console.WriteLine($"you found {results} {((results == 1) ? "city" : "cities")} with the name {city}!\n");

                        //specify when multiple results
                        while (results > 1)
                        {
                            neededCountry = true;
                            results = 0;
                            code = AskForCity(true, city);
                            Console.Clear();

                            command = new SqlCommand("Select country, name, population FROM city WHERE name = @Name AND country = @Code", connection);
                            command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = city;
                            command.Parameters.Add("@Code", SqlDbType.NVarChar, 80).Value = code;

                            command.Connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ++results;
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.Write(reader[i] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            command.Connection.Close();
                        }
                    }
                    Console.WriteLine();

                    //update and read new data
                    try
                    {
                        //ask for population update and update data
                        using (SqlCommand update = new SqlCommand("UPDATE city SET population = (population + @Change) WHERE name = @Name", connection))
                        {
                            if (neededCountry)
                            {
                                update.CommandText = "UPDATE city SET population = (population + @Change) WHERE name = @Name AND country = @Code";
                            }
                            command.Connection.Open();

                            int populationChange = AskForPopulationChange();
                            Console.Clear();

                            update.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = city;
                            update.Parameters.Add("@Change", SqlDbType.Int).Value = populationChange;

                            if (neededCountry)
                            {
                                update.Parameters.Add("@Code", SqlDbType.NVarChar).Value = code;
                            }

                            update.ExecuteNonQuery();

                            update.Connection.Close();
                        }


                        //show updated data
                        Console.WriteLine("new data:\n");
                        command.Connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write(reader[i] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                        command.Connection.Close();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.WriteLine("wanna go again? enter 'Yes' or 'Y' for yes.");
                    wannaGoAgain = Console.ReadLine().ToLower();
                    Console.Clear();
                }
                Console.WriteLine("bye!");
            }
        }


        public static string AskForCity(bool country = false, string city = "")
        {
            if (!country)
            {
                Console.WriteLine("What city are you searching for?");
            }
            else
            {
                Console.WriteLine($"from which country should {city} be? please enter the code shown on the left \nenter something different if you want to chose another city");
            }


            string? input = Console.ReadLine();

            return (input != null) ? input : "";
        }


        public static int AskForPopulationChange()
        {
            Console.WriteLine("How many people do you want to add?");

            int input = 0;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Sorry, not sure what you mean. try again, only integers!");
            }

            return input;
        }


        public static void AdjustingTable(int buffer = 3)
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT c.Name, c.Code, c.Capital, c.Population, c.Area, Round((c.population/c.area),2) as popDensity, e.continent FROM country as c JOIN encompasses as e ON c.code = e.country ORDER BY popDensity DESC", connection);
                //SqlCommand commandSize = new SqlCommand("SELECT c.Name, c.Code, c.Capital, c.Population, c.Area, Round((c.population/c.area),2) as popDensity FROM country as c JOIN encompasses as e ON c.code = e.country WHERE e.continent = 'europe' ORDER BY popDensity DESC", connection);

                int colCount;
                int[] sizes;
                List<DbColumn> header;

                try
                {
                    command.Connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        header = reader.GetColumnSchema().ToList();
                        colCount = header.Count;
                        sizes = new int[colCount];
                    }

                    //save col sizes
                    for (int col = 0; col < colCount; col++)
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int max = 0;
                            while (reader.Read())
                            {
                                int temp = reader[col].ToString().Length;

                                max = (temp > max) ? temp : max;
                            }
                            sizes[col] = max + buffer;
                        }
                    }


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //top row
                        for (int i = 0; i < header.Count; i++)
                        {
                            int size = sizes[i];

                            if (header[i].DataTypeName == "float")
                            {
                                Console.Write("─┬─" + "".PadLeft(size, '─'));
                            }
                            else
                            {
                                Console.Write(("─┬─" + "").PadRight(size, '─'));
                            }
                        }
                        Console.WriteLine("─┬─");

                        //write header
                        for (int i = 0; i < header.Count; i++)
                        {
                            int size = sizes[i];

                            if (header[i].DataTypeName == "float")
                            {
                                Console.Write(" │ " + (header[i].ColumnName).PadLeft(size));
                            }
                            else
                            {
                                Console.Write((" │ " + header[i].ColumnName).PadRight(size));
                            }
                        }
                        Console.WriteLine(" │ ");

                        //header underline
                        for (int i = 0; i < header.Count; i++)
                        {
                            int size = sizes[i];

                            if (header[i].DataTypeName == "float")
                            {
                                Console.Write("─┼─" + "".PadLeft(size, '─'));
                            }
                            else
                            {
                                Console.Write("─┼─".PadRight(size, '─'));
                            }
                        }
                        Console.WriteLine("─┼─");

                        //write body
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                int size = sizes[i];

                                if (header[i].DataTypeName == "float")
                                {
                                    Console.Write(" │ " + reader[i].ToString().PadLeft(size));
                                }
                                else
                                {
                                    Console.Write((" │ " + reader[i]).PadRight(size));
                                }
                            }
                            Console.WriteLine(" │ ");
                        }

                        //bottom row
                        for (int i = 0; i < header.Count; i++)
                        {
                            int size = sizes[i];

                            if (header[i].DataTypeName == "float")
                            {
                                Console.Write("─┴─" + "".PadLeft(size, '─'));
                            }
                            else
                            {
                                Console.Write(("─┴─" + "").PadRight(size, '─'));
                            }
                        }
                        Console.WriteLine("─┴─");
                    }
                }
                catch (SqlException se)
                {
                    Console.WriteLine("failure");
                    Console.WriteLine(se.Message);
                }
            }
        }


        public static string GetConnectionString()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:192.168.0.77,1433;User=Michael;Password=Michael";
            //return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Michael Hämmerle;Password=Kyan2003*";
        }
    }
}
