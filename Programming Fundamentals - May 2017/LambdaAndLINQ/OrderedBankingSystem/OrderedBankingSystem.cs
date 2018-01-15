using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var banksInfo = new Dictionary<string, Dictionary<string, decimal>>();

            while (line != "end")
            {
                FillBankInfo(line, banksInfo);

                line = Console.ReadLine();
            }

            PrintBankInfo(banksInfo);
        }

        static void FillBankInfo(string line, Dictionary<string, Dictionary<string, decimal>> banksInfo)
        {
            string[] tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string bank = tokens[0];
            string account = tokens[1];
            decimal balance = decimal.Parse(tokens[2]);

            if (!banksInfo.ContainsKey(bank))
            {
                banksInfo[bank] = new Dictionary<string, decimal>();
            }

            if (!banksInfo[bank].ContainsKey(account))
            {
                banksInfo[bank][account] = 0;
            }
            banksInfo[bank][account] += balance;
        }

        static void PrintBankInfo(Dictionary<string, Dictionary<string, decimal>> banksInfo)
        {
            /*var orderedBanksInfo = banksInfo
                    .OrderByDescending(x => x.Value.Values.Sum())
                    .ThenByDescending(x => x.Value.Values.Max());
            */

            var orderedBanksInfo = banksInfo
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value));

            foreach (var bankInfo in orderedBanksInfo)
            {
                string bank = bankInfo.Key;
                var bankAccounts = bankInfo.Value;

                var orderedBankAccounts = bankAccounts.OrderByDescending(x => x.Value);

                foreach (var bankAccount in orderedBankAccounts)
                {
                    string account = bankAccount.Key;
                    decimal balance = bankAccount.Value;

                    Console.WriteLine($"{account} -> {balance} ({bank})");
                }
            }

            //banksInfo
            //    .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
            //    .ThenByDescending(bank => bank.Value.Max(account => account.Value))
            //    .ToList()
            //    .ForEach(bank => bank.Value
            //        .OrderByDescending(account => account.Value)
            //        .ToList()
            //        .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));
        }
    }
}
