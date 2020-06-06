using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int badges, List<Pokemon> pokemon)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemons = pokemon;
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}
