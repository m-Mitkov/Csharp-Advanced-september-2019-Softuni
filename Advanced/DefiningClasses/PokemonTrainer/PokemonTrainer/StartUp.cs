using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<Trainer> trainers = new HashSet<Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealt = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealt);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    List<Pokemon> pokemons = new List<Pokemon>();
                    pokemons.Add(pokemon);

                    Trainer trainer = new Trainer(trainerName, 0, pokemons);
                    trainers.Add(trainer);
                }

                else
                {
                    var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                    trainer.Pokemons.Add(pokemon);
                }
            }

            while (true)
            {
                string inputElement = Console.ReadLine();

                if (inputElement == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == inputElement))
                    {
                        trainer.Badges++;
                    }

                    else
                    {
                        trainer.Pokemons
                            .Select(x => x.Healt -= 10)
                            .ToList();

                        trainer.Pokemons = trainer.Pokemons
                            .Where(x => x.Healt > 0)
                            .ToList();
                    }
                }
            }

            trainers = trainers
                .OrderByDescending(x => x.Badges)
                .ToHashSet();

            Console.WriteLine(string.Join(Environment.NewLine, trainers));
        }
    }
}
