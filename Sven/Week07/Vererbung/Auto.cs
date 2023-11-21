

namespace Sven.Week07.Modelierung
{
    public class Auto
    {
        protected string _ModellName;
        private string _Color;
        private int _HorsePower;
        //private bool _Used;

        public Auto(string name, string color, int hp)
        {
            _ModellName = name;
            _Color = color;
            _HorsePower = hp;
            //_Used = used;

        }
        public virtual void PrintCar()
        {
            Console.WriteLine($"Modell: {_ModellName}\nHorsepower: {_HorsePower}\nColor: {_Color}");

        }
    }
}






