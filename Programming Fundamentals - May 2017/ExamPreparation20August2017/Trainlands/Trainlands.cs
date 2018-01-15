using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainlands
{
    class Wagon
    {
        public string Name { get; set; }

        public int Power { get; set; }

        public Wagon(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
    }

    class Trainlands
    {
        static Dictionary<string, List<Wagon>> trains;

        static void Main(string[] args)
        {
            trains = new Dictionary<string, List<Wagon>>();

            string input;
            while ((input = Console.ReadLine()) != "It's Training Men!")
            {
                string[] tokens = input.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    CreateTrain(tokens);
                }
                else
                {
                    string[] trainTokens = tokens[0].Split();
                    string trainName = trainTokens[0];
                    string delimiter = trainTokens[1];
                    string otherTrainName = trainTokens[2];

                    if (delimiter == "->")
                    {
                        AddWagons(trainName, otherTrainName);
                        RemoveTrain(otherTrainName);
                    }
                    else if (delimiter == "=")
                    {
                        CopyWagons(trainName, otherTrainName);
                    }
                }
            }

            PrintTrains();
        }

        static void PrintTrains()
        {
            foreach (var train in trains.OrderByDescending(x => x.Value.Sum(y => y.Power)).ThenBy(x => x.Value.Count))
            {
                string trainName = train.Key;
                List<Wagon> wagons = train.Value;

                Console.WriteLine("Train: {0}", trainName);

                foreach (Wagon wagon in wagons.OrderByDescending(x => x.Power))
                {
                    Console.WriteLine("###{0} - {1}", wagon.Name, wagon.Power);
                }
            }
        }

        static void RemoveTrain(string otherTrainName)
        {
            trains.Remove(otherTrainName);
        }

        static void AddWagons(string trainName, string otherTrainName)
        {
            List<Wagon> otherTrainWagons = trains[otherTrainName];

            if (!trains.ContainsKey(trainName))
            {
                trains[trainName] = new List<Wagon>();                
            }
            trains[trainName].AddRange(otherTrainWagons);
        }

        static void CopyWagons(string trainName, string otherTrainName)
        {
            List<Wagon> otherTrainWagons = trains[otherTrainName];

            trains[trainName] = new List<Wagon>(otherTrainWagons);
        }

        static void CreateTrain(string[] tokens)
        {
            string trainName = tokens[0].Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).First();
            string wagonName = tokens[0].Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).Last();
            int wagonPower = int.Parse(tokens[1]);

            Wagon wagon = new Wagon(wagonName, wagonPower);

            if (!trains.ContainsKey(trainName))
            {
                trains[trainName] = new List<Wagon>();
            }
            trains[trainName].Add(wagon);
        }
    }
}
