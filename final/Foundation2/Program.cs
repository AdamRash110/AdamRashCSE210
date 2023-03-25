using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("123456789", "user123", "password123", 1000.0m);
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            if (!account.Authenticate(username, password))
            {
                Console.WriteLine("Invalid username or password.");
                return;
            }

            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check balance");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the deposit amount:");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine("Deposit successful. New balance: {0:C}", account.GetBalance());
                    break;

                case 2:
                    Console.WriteLine("Enter the withdrawal amount:");
                    decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                    try
                    {
                        account.Withdraw(withdrawalAmount);
                        Console.WriteLine("Withdrawal successful. New balance: {0:C}", account.GetBalance());
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 3:
                    Console.WriteLine("Current balance: {0:C}", account.GetBalance());
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}