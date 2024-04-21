using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; } 

        public Pokemon(string pokemonName,string element, int health) 
        { 
            Name = pokemonName;
            Element = element;
            Health = health;
        }
    }
}
