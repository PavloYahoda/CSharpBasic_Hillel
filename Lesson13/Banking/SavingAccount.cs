using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class SavingAccount : BankAccount
    {
        private double interestRate;
        public double InterestRate { get; set; }

        public SavingAccount(string name, double interestRate) : base(name) 
        {
            InterestRate = interestRate;
        }
        public override void Deposit(double amount)
        {
            double interest = amount * InterestRate / 100;
            Balance += amount + interest;
            Console.WriteLine("Account top-up is successful");
        }

        public override void Withdraw(double amount)
        {
            if (Balance < amount)
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
                $"Balance: {Balance}\n" +
                $"InterestRate: {InterestRate}\n" +
                $"Interest: {(Balance - Balance / (1 + InterestRate / 100)):F2}");
            Console.WriteLine("--------");
        }
    }
}
