using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];
                string username = input[1];            

                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    PrintOutput(RegisterNewUser(parkingLot, username, licensePlateNumber));
                }
                else if (command == "unregister")
                {
                    PrintOutput(UnregisterExistingUser(parkingLot, username));
                }
            }

            foreach (var kvp in parkingLot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }

        private static string UnregisterExistingUser(Dictionary<string, string> parkingLot, string username)
        {
            if (!parkingLot.ContainsKey(username))
            {
                string message = "ERROR: user " + username + " not found";
                return message;
            }
            else
            {
                parkingLot.Remove(username);
                string message = "user " + username + " unregistered successfully";
                return message;
            }
        }

        private static string RegisterNewUser(Dictionary<string, string> parkingLot, string username, string licensePlateNumber)
        {
            if (parkingLot.ContainsKey(username))
            {
                string message = "ERROR: already registered with plate number " + parkingLot[username];
                return message;
            }
            else if (!CheckForValidLicensePlate(licensePlateNumber))
            {
                string message = "ERROR: invalid license plate " + licensePlateNumber;
                return message;
            }
            else if (parkingLot.ContainsValue(licensePlateNumber))
            {
                string message = "ERROR: license plate " + licensePlateNumber + " is busy";
                return message;
            }
            else
            {
                parkingLot.Add(username, licensePlateNumber);
                string message = username + " registered " + licensePlateNumber + " successfully";
                return message;
            }
        }

        private static bool CheckForValidLicensePlate(string licensePlateNumber)
        {
            bool hasValidNumbers = licensePlateNumber.ToCharArray()
                .Skip(2)
                .Take(4)
                .All(digit => char.IsDigit(digit));

            bool hasValidLetters = licensePlateNumber.ToCharArray()
                .Take(2)
                .Concat(licensePlateNumber.ToCharArray().Skip(6).Take(2).ToArray())
                .All(letters => char.IsUpper(letters));

            bool isValid = hasValidNumbers && hasValidLetters && licensePlateNumber.Length == 8;
            return isValid;
        }

        static void PrintOutput(string input)
        {
            Console.WriteLine(input);
        }
    }
}
