// See https://aka.ms/new-console-template for more information

using Lukas.Week11;

var data = LoadProperties.Load("Lukas.configuration.properties");

if (!data.ContainsKey("DATA_BASE_CONNECTION_STRING"))
{
    Console.WriteLine("Please specify: DATA_BASE_CONNECTION_STRING=xyz in configuration.properties");
}
else
{
    Console.WriteLine(data["DATA_BASE_CONNECTION_STRING"]);
}

Console.ReadLine();
