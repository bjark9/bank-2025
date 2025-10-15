namespace BankApplication
{
    class Account
    {
        // { get; set; } : get -> allows reading of variable, set -> allows assigning value to variable
        public long AccountNumber { get; set; } // Long type (16 numbers)
        public required string IBAN { get; set; } // Alphanumeric
        public long Balance { get; set; }
        public required string Name { get; set; }
        public required string FirstName { get; set; }

        public void Transaction(long amount, bool transaction = true) // If transaction = true -> add montant
        {
            // Maybe add function for when balance - amount < 0 ?
            if (transaction == false && (Balance - amount < 0))
            {
                Console.WriteLine("You don't have enough money on your bank account.");
                return;
            }
            Balance += (transaction) ? amount : -amount;
        }
        // Maybe add function for when balance - amount < 0 ?
    }
}