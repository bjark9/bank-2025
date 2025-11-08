namespace BankApplication_Personnel
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

        public void Transaction(long amount, long accTypeNumber, bool transaction = true) // If transaction = true -> add montant
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

namespace BankApplication_Cours
{
    public interface IAccount
    {
        public double Balance { get; }
        public void Withdraw(double amount);
        public void Deposit(double amount);
    }
    abstract class Account : IAccount
    {
        // Cette classe va être la classe parente dont SavingsAccount et CurrentAccount vont hériter
        public required string AccNumber { get; set; }
        public double Balance { get; private set; }
        public required BankApplication_Cours.Person Owner { get; set; }
    
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        abstract protected double CalculInterest();
        public void ApplyInterest()
        {
            Balance += CalculInterest();
        }
    }
}