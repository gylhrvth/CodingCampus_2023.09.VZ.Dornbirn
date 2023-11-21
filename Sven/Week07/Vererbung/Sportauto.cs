

using System.Xml.Linq;

namespace Sven.Week07.Modelierung
{
    public class Sportauto : Auto
    {
        private int _Price;

        public Sportauto(string name, string color, int hp, int price) : base(name, color, hp)
        {
            _Price = price;
        }

        public override void PrintCar()
        {
            Console.WriteLine($"Ich bin {_ModellName} und ich bin MEHR als ein Obst!");
        }
    }
    
}
