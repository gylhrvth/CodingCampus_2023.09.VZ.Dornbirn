namespace Gheorghe.Week06.Personen
{
    public class Person
    {
        public int Groesse { get; set; }
        public int Alter { get; set; }
        public string Name { get; set; }
        public int Gewicht { get; set; }

        public Person(int groesse, int alter, string name, int gewicht)
        {
            Groesse = groesse;
            Alter = alter;
            Name = name;
            Gewicht = gewicht;

        }
        public override string ToString()
        {
            return $"Namme:  {Groesse}\ncm, {Alter}\nalt, {Name}\nname, {Gewicht}\nkg ";
        }


    }

}
