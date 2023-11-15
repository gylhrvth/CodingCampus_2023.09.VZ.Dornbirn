using Mehmet.ZOO;

namespace Mehmet.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Cage> _CageList;
        private List<Worker> _WorkerList;
        



        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _CageList = new List<Cage>();
           _WorkerList = new List<Worker>();
        }

        public void AddCage(Cage cage)
        {
            _CageList.Add(cage);           
        }

        public void AddWorker(Worker worker)
        {
            _WorkerList.Add(worker);
        }





        public void PrintStrukture()
        {
            Console.WriteLine("├──┬┤ Zoo: Tiergarten {0}, gegründet {1}",
                _Name,
                _Founded);
            foreach (Worker worker in _WorkerList)
            {
                worker.PrintStrukture();
            }
            foreach (Cage cage in _CageList)
            {
                cage.PrintStrukture();               
            }
            

        }





    }
}
