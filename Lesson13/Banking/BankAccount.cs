using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string accountHolder;
        private double balance = 0;

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string name) {
            AccountHolder = name;
            AccountNumber = Helper.createBankAccountNumber(14);
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void DisplayAccountInfo();

    }
}
