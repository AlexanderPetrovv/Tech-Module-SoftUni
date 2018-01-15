using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var travelInfo = new Dictionary<string, Dictionary<string, int>>();

            while(line != "ready")
            {
                string[] input = line.Split(':');
                string city = input[0];
                string[] vehicleData = input[1].Split(new char[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < vehicleData.Length; i += 2)
                {
                    string vehicle = vehicleData[i];
                    int capacity = int.Parse(vehicleData[i + 1]);

                    if (!travelInfo.ContainsKey(city))
                    {
                        travelInfo[city] = new Dictionary<string, int>();
                    }
                    travelInfo[city][vehicle] = capacity;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            
            while (line != "travel time!")
            {
                string[] input = line.Split(' ');
                string destination = input[0];
                int passengers = int.Parse(input[1]);

                int availableSeats = travelInfo[destination].Select(x => x.Value).Sum();

                if (availableSeats >= passengers)
                {
                    Console.WriteLine($"{destination} -> all {passengers} accommodated");
                }
                else
                {

                    Console.WriteLine($"{destination} -> all except {passengers - availableSeats} accommodated");
                }

                line = Console.ReadLine();
            }   
        }
    }
}
