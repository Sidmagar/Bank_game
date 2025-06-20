using System;

namespace BankGameApp
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double startingBalance)
        {
            AccountHolder = accountHolder;
            Balance = startingBalance >= 0 ? startingBalance : 0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"{AccountHolder} deposited {amount:C}. New balance: {Balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine($"Withdrawal failed! {AccountHolder} has insufficient balance.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{AccountHolder} withdrew {amount:C}. New balance: {Balance:C}");
        }
    }
}
