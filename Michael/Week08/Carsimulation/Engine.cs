using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.Carsimulation
{
    internal class Engine
    {
        private Random rnd = new Random();
        private double _DefectProbabilityPerKilometer;
        private bool _Broken = false;

        public Engine(double defectProbabilityPerKilometer)
        {
            _DefectProbabilityPerKilometer = defectProbabilityPerKilometer;
        } 


        public bool Broken { get => _Broken; }


        public void BreakEngine()
        {
            _Broken = true;
        }


        public void RepairEngine()
        {
            _Broken = false;
        }


        public bool BreakingDuringDrive()
        {
            double chance = (double)rnd.Next(100);

            bool breaks = chance < _DefectProbabilityPerKilometer;
            
            if (breaks) BreakEngine();

            return breaks;
        }
    } 
}
