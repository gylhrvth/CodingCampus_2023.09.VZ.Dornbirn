

namespace Sven.Week07.Modelierung
{
    public class MittelKlasseAutos : Auto
    {

        private int _Price;

        public MittelKlasseAutos( string name , string color, int hp, int price) : base (name, color, hp)
        {
            _Price = price;
        }



    }
}
