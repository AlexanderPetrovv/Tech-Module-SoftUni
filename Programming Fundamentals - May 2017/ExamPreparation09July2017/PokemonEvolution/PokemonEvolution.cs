using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string Type { get; set; }

        public int Index { get; set; }

        public Pokemon(string type, int index)
        {
            this.Type = type;
            this.Index = index;
        }
    }

    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var pokemons = new Dictionary<string, List<Pokemon>>();

            string input;

            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.None);

                string pokemonName = tokens[0];

                if (tokens.Length > 1)
                {
                    string evolutionType = tokens[1];
                    int evolutionIndex = int.Parse(tokens[2]);

                    Pokemon pokemon = new Pokemon(evolutionType, evolutionIndex);

                    if (!pokemons.ContainsKey(pokemonName))
                    {
                        pokemons[pokemonName] = new List<Pokemon>();
                    }
                    pokemons[pokemonName].Add(pokemon);
                }
                else
                {
                    if (pokemons.ContainsKey(pokemonName))
                    {
                        Console.WriteLine("# {0}", pokemonName);

                        foreach (var pokemon in pokemons[pokemonName])
                        {
                            Console.WriteLine("{0} <-> {1}", pokemon.Type, pokemon.Index);
                        }
                    }
                }
            }

            foreach (var pokemon in pokemons)
            {
                string pokemonName = pokemon.Key;
                var evolutions = pokemon.Value;

                Console.WriteLine("# {0}", pokemonName);

                foreach (var evolution in evolutions.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine("{0} <-> {1}", evolution.Type, evolution.Index);
                }
            }
        }
    }
}
