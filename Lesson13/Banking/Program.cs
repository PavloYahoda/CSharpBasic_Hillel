using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount pyahDepositAccount = new SavingAccount("Pavlo Yahoda", 12);
            BankAccount pyahPersonalAccount = new CheckingAcccount("Pavlo Yahoda", 1000);

            pyahDepositAccount.DisplayAccountInfo();
            pyahDepositAccount.Deposit(10000);
            pyahDepositAccount.DisplayAccountInfo();
            pyahDepositAccount.Withdraw(20000);
            pyahDepositAccount.Withdraw(6000);
            pyahDepositAccount.DisplayAccountInfo();
            Console.WriteLine("-----------------------------------");
            pyahPersonalAccount.DisplayAccountInfo();
            pyahPersonalAccount.Deposit(10000);
            pyahPersonalAccount.DisplayAccountInfo();
            pyahPersonalAccount.Withdraw(20000);
            pyahPersonalAccount.Withdraw(10500);
            pyahPersonalAccount.DisplayAccountInfo();

            Console.ReadKey();
        }
    }
}
