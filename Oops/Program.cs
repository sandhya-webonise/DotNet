namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new MyBankAccount("Sandhya", 10000);
            Console.WriteLine($"Account has been created with {account.Number} for {account.Owner} has {account.Balance} Balance");
            account.MyWithdrawal(200, DateTime.Now, "Travel");
            Console.WriteLine(account.Balance);
            account.MyWithdrawal(100, DateTime.Now, "Carrom");
            Console.WriteLine(account.Balance);

            // Get account transactions 
            Console.WriteLine(account.getAllTransactions());
            // Test for a Negative balance 
            try
            {
                account.MyWithdrawal(750000, DateTime.Now, "WithDraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error User is trying to withdraw excess amount");
                Console.WriteLine(e.ToString());
            }
            // Test that the initial balance for creating an account must be positive only 
            try
            {
                var invalidAccount = new MyBankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error User is trying to create account with negative balance");
                Console.WriteLine(e.ToString());
            }

        }
    }
}