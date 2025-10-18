namespace BankApplication
{
    class Account
    {
        // { get; set; } : get -> allows reading of variable, set -> allows assigning value to variable
        public long CheckingAccountNumber { get; set; } // Long type (16 numbers)
        public long SavingAccountNumber { get; set; }
        public long CheckingAccBalance { get; set; }
        public long SavingAccBalance { get; set; }
        public required string IBAN { get; set; } // Alphanumeric
        public required string Name { get; set; }
        public required string FirstName { get; set; }
        
        public void Transaction(long amount, long accTypeNumber,bool transaction = true) // If transaction = true -> add montant
        {
            long Balance = 0;
            if (accTypeNumber == CheckingAccountNumber)
            {
                Balance = CheckingAccBalance;
            }
            else
            {
                Balance = SavingAccBalance;
            }

            if (transaction == false && (Balance - amount < 0))
            {
                Console.WriteLine("You don't have enough money on your account.");
                return;
            }
            Balance += (transaction) ? amount : -amount;
        }

        public long ShowCheckingAccountBalance()
        {
            return CheckingAccBalance;
        }
        public long SumOfAllAccountsBalance()
        {
            return (CheckingAccBalance + SavingAccBalance);
        }
    }
}