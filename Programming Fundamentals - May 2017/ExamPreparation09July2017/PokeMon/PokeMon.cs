using System;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetsDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            double halfPower = pokePower / 2.0;

            int pokedTargets = 0;
            while (pokePower >= pokeTargetsDistance)
            {
                if (pokePower == halfPower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }

                    if (pokePower >= pokeTargetsDistance)
                    {
                        pokePower -= pokeTargetsDistance;
                        pokedTargets++;
                    }
                }
                else
                {
                    pokePower -= pokeTargetsDistance;
                    pokedTargets++;
                }
                
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
