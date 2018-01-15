using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<BankAccount> bankAccounts = new List<BankAccount>();

            while (line != "end")
            {
                string[] tokens = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string bankName = tokens[0];
                string accountName = tokens[1];
                decimal accountBalance = decimal.Parse(tokens[2]);

                bankAccounts.Add(new BankAccount { Bank = bankName, Name = accountName, Balance = accountBalance });

                line = Console.ReadLine();
            }

            var orderedBankAccounts = bankAccounts.OrderByDescending(acc => acc.Balance).ThenBy(acc => acc.Bank.Length).ToList();

            foreach (var bankAccount in orderedBankAccounts)
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }
    }
}
