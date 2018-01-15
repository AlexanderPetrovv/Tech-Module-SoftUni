using System;

namespace PokeMon2
{
    class PokeMon2
    {
        static void Main(string[] args)
        {
            // O(1) Solution

            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetsDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int checkForTargetCnt = pokePower / pokeTargetsDistance;
            int checkForRemainingPower = pokePower % pokeTargetsDistance;

            if (checkForTargetCnt % 2 == 0 && checkForRemainingPower == 0 && exhaustionFactor > 0)
            {
                pokePower = pokePower / 2 + ((pokePower / 2) / exhaustionFactor);
            }

            int pokedTargetsCnt = pokePower / pokeTargetsDistance;
            int remainingPower = pokePower % pokeTargetsDistance;

            Console.WriteLine(remainingPower + Environment.NewLine + pokedTargetsCnt);
        }
    }
}
