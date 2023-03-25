using System;

namespace BankAccount
{
    public class Account
    {
        private decimal balance;
        private string accountNumber;
        private string username;
        private string password;

        public Account(string accountNumber, string username, string password, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.username = username;
            this.password = password;
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public bool Authenticate(string username, string password)
        {
            return this.username == username && this.password == password;
        }
    }
}