using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> PokemonCollection { get; set; }


        public Trainer(string trainerName)
        {
            Name = trainerName;
            NumberOfBadges = 0;
            PokemonCollection = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            PokemonCollection.Add(pokemon);
        }
    }
}
