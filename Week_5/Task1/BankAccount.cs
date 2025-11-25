using System;

namespace Week_5.Task1
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                    balance = value;
            }
        }

        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;
            if (initialBalance > 0)
                balance = initialBalance;
            else
                Console.WriteLine("Initial balance must be positive.");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount or insufficient funds.");
            }
        }
    }
}
