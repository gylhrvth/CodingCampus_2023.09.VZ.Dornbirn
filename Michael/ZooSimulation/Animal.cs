using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Michael.ZooSimulation
{
    internal class Animal
    {
        Random rnd = new Random();


        private string _Name;
        public string Name { get => _Name; }


        private string _Species;
        public string Species { get => _Species; }


        private Food _Food;
        public Food Food { get => _Food; }


        private double _FoodAmount;
        public double FoodAmount { get => _FoodAmount; }


        private Enclosure _Enclosure;
        public Enclosure Enclosure { get => _Enclosure; }


        private int _MaxHealth;
        public int MaxHealth { get => _MaxHealth; }


        private int _CurrentHealth;
        public int CurrentHealth { get => _CurrentHealth; }


        private (int,int) _BiteDamage;
        public (int,int) BiteDamage { get => _BiteDamage; }


        private bool _Fed = false;
        public bool Fed { get => _Fed; }


        private bool _Alive = true;
        public bool Alive { get => _Alive; }



        //-------------------------------------------------------


        public bool Feed(Food food)
        {
            if (food == Food && !_Fed)
            {
                _Fed = true;
                return true;
            }

            return false;
        }


        public void Sleep()
        {
            _Fed = false;
        }


        public void GetsHealed(Veterenarian vet)
        {
            int healthPoints = rnd.Next((int)(0.3 * (double)_MaxHealth), _MaxHealth);
            Console.WriteLine($"{_Name} the {_Species} gets healed for {healthPoints} points by {vet.Name}.");
            Console.WriteLine($"Its health rises from {_CurrentHealth} to {Math.Min(_CurrentHealth + healthPoints, _MaxHealth)}.");
            _CurrentHealth = Math.Min(_CurrentHealth + healthPoints, _MaxHealth);
        }


        public void PrintSelf(string prefix)
        {
            Console.WriteLine($"{prefix}├──{this}");
        }


        public void AddEnclosure(Enclosure enc)
        {
            _Enclosure = enc;
        }


        public bool GetsFed(Carer carer, string prefix)
        {
            if (_Fed)
            {
                Console.WriteLine(prefix + $"{_Name} was already fed.");
                return false;
            }
            else
            {
                Console.WriteLine(prefix + $"{carer.Name} gave {_Name} the {_Species} some {_Food}.");
                _Fed = true;
                return true;
            }
        }


        public void GetsBitten(int damage, Animal attacker)
        {
            Console.WriteLine($"{attacker.Name} the {attacker.Species} attacks {_Name} the {_Species} for {damage} damage.");
            Console.WriteLine($"Its health drops from {_CurrentHealth} to {Math.Max(_CurrentHealth - damage , 0)}.");
            _CurrentHealth -= damage;

            if ( _CurrentHealth <= 0)
            {
                Console.WriteLine($"{_Name} the {_Species} has perished");
                _Alive = false;
            }

            Console.WriteLine();
        }


        public void Bites(Animal victim)
        {
            int damage = rnd.Next(_BiteDamage.Item1, _BiteDamage.Item2);

            if (rnd.Next(100) == 0)
            {
                Console.WriteLine(_Name + " hat seine supersprung fähigkeit ausgeführt und landete auf ..."+ victim.Name + "und gab ihm " + victim.MaxHealth + " damage");
                damage = victim.MaxHealth;
            }
            victim.GetsBitten(damage, this);
        }


        public Animal(string name,  string species, int maxHealth, (int,int) biteDamage, Food food)
        {
            _Name = name;
            _Species = species;
            _MaxHealth = maxHealth;
            _BiteDamage = biteDamage;
            _CurrentHealth = maxHealth;
            _Food = food;
        }


        public override string ToString()
        {
            string returnString = "";

            returnString += $"{ _Name}, { _Species}";

            if (!_Alive) returnString += " (deceased)";

            return returnString;
        }

    }
}
