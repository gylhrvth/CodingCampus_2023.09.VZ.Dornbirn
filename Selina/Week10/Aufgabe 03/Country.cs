namespace Selina.Week10.Aufgabe_03
{
    public class Country
    {
        private string name;
        private string code;
        private string capital;
        private string province;
        private float area;
        private float population;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Code
        {
            get => code;
            set => code = value;
        }
        public float Area
        {
            get => area;
            set => area = value;
        }
        public float Population
        {
            get => population;
            set => population = value;
        }
        public string Capital
        {
            get => capital;
            set => capital = value;
        }
        public string Province
        {
            get => province;
            set => province = value;
        }


        public Country()
        {

        }
        public Country(string nameOfCountry, string code, string capital, string province, float area, float population)
        {
            this.name = nameOfCountry;
            this.code = code;
            this.capital = capital;
            this.province = province;
            this.area = area;
            this.population = population;
        }
    }
}
