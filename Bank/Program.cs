


namespace BankGameApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            BankAccount account1 = new BankAccount("Account1", rand.Next(1000, 5001));
            BankAccount account2 = new BankAccount("Account2", rand.Next(1000, 5001));

            Console.WriteLine($"Starting Balances:\n{account1.AccountHolder}: {account1.Balance:C}\n{account2.AccountHolder}: {account2.Balance:C}\n");

            //  3 rounds
            for (int round = 1; round <= 3; round++)
            {
                Console.WriteLine($"--- Round {round} ---");

                PerformTransaction(account1);
                PerformTransaction(account2);

                Console.WriteLine();
            }

            //  winner
            Console.WriteLine("----- Game Over -----");
            Console.WriteLine($"{account1.AccountHolder} final balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.AccountHolder} final balance: {account2.Balance:C}");

            if (account1.Balance > account2.Balance)
                Console.WriteLine($"{account1.AccountHolder} wins!");
            else if (account2.Balance > account1.Balance)
                Console.WriteLine($"{account2.AccountHolder} wins!");
            else
                Console.WriteLine("It's a tie!");
        }

        private static void PerformTransaction(BankAccount account)
        {
            while (true)
            {
                Console.Write($"{account.AccountHolder} Withdraw or Deposit (w/d): ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "w" || input == "d")
                {
                    Console.Write($"Amount to {(input == "w" ? "Withdraw" : "Deposit")}: ");
                    if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                    {
                        if (input == "w")
                            account.Withdraw(amount);
                        else
                            account.Deposit(amount);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount! Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 'w' to withdraw or 'd' to deposit.");
                }
            }
        }
    }
}
