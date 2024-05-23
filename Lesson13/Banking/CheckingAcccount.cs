using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class CheckingAcccount : BankAccount
    {
        private double overdraftLimit;
        public double OverdraftLimit { get; set; }

        public CheckingAcccount(string name, double overdraftLimit) : base(name)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Account top-up is successful");
        }

        public override void Withdraw(double amount)
        {
            if ((Balance + OverdraftLimit) < amount)
            {
                Console.WriteLine("You don't have enough money in your account");
            }
            else 
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal is successful");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Account holder: {AccountHolder}\n" +
                $"Account number: {AccountNumber}\n" +
                $"Balance: {Balance}");
            if (Balance < 0) 
            {
                Console.WriteLine($"Overdraft limit: {OverdraftLimit + Balance}");
            }
            else {
                Console.WriteLine($"Overdraft limit: {OverdraftLimit}");
            }
            Console.WriteLine("-------");
        }
    }
}
