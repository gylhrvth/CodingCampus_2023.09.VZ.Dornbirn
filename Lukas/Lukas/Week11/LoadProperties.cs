namespace Lukas.Week11
{
    public class LoadProperties
    {
        //Create file:
        //xyz.properties in project folder
        //Add following into csproj file:
        //<Project>
        //  ...
        //  <ItemGroup>
        //      <EmbeddedResource Include = "configuration.properties" />
        //  </ ItemGroup >
        //  ...
        //</Project>
        public static Dictionary<string, string> Load(string name)
        {
            var file = new StreamReader(typeof(DatabaseStart).Assembly.GetManifestResourceStream(name));
            var lines = new List<string>();
            while (true)
            {
                string line = file.ReadLine();
                if (line == null)
                {
                    break;
                }
                lines.Add(line);
            }

            var data = new Dictionary<string, string>();
            foreach (var row in lines)
            {
                data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));
            }
            return data;
        }
    }
}

