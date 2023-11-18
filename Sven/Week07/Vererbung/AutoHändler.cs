
namespace Sven.Week07.Modelierung
{
    public class AutoHändler
    {
        public static void Start()
        {
            List<Auto> waren = new List<Auto>();

            waren.Add(new Sportauto("bmw", "pink", 2, 5));
            waren.Add(new Auto("vw", "gelb", 10));

            
            foreach (Auto autos in waren) 
            {

                autos.PrintCar();

            }

        }
       

    }
}
