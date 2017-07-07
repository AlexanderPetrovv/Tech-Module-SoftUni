using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = String.Empty;
            int energyDrop;
            int index = 0;
            bool bombHit = false;

            while (initialEnergy > 0)
            {          
                string[] token = input[index].Split('|').ToArray();
                command = token[0];
                bombHit = false;
                if (command == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                energyDrop = int.Parse(token[1]);

                switch (command)
                {
                    case "Left":
                        index = Math.Abs(index - energyDrop) % input.Count;
                        initialEnergy -= energyDrop;
                        break;
                    case "Right":
                        index = (index + energyDrop) % input.Count;
                        initialEnergy -= energyDrop;
                        break;
                    case "Bomb":
                        input.RemoveAt(index);
                        index = 0;
                        initialEnergy -= energyDrop;
                        bombHit = true;
                        break;
                }

                if (input[input.Count - 1] != "RabbitHole")
                {
                    input.RemoveAt(input.Count - 1);
                }
                input.Add("Bomb|" + initialEnergy);
        }

            if (initialEnergy <= 0 && bombHit)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }
            else if (initialEnergy <= 0 && !bombHit)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
        }
    }
}
