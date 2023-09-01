using System.Text;

namespace MyBank
{
    public class MyBankAccount
    {
        //Defining and making an object using C# 
        // Properties of Bank Account
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var bal in allTransactions)
                {
                    balance += bal.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();
        private static int accountNumberSeed = 1234567890;



        // Constructor 
        public MyBankAccount(string name, decimal initialBal)
        {
            this.Owner = name;
            MyDeposit(initialBal, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }
        // Functions can be performed in Banks
        public void MyDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount for deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MyWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount for withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No sufficient balance");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string getAllTransactions()
        {
            var history = new StringBuilder();
            //Header 
            history.AppendLine("Date\t\tAmount\t\tNote");
            foreach (var val in allTransactions)
            {
                //ROWS
                history.AppendLine($"{val.Date.ToShortDateString()}\t{val.Amount}\t{val.Notes}");
            }
            return history.ToString();
        }
    }
}