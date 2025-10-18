using BankApplication_Personnel;

namespace BankApplication
{
    class SavingsAccount : BankApplication_Cours.Account
    {
        public DateTime DateLastWithdraw { get; set; }
        protected override double CalculInterest()  // Need to put protected, bcs if base is protected, override needs to be protected too
                                                    // Public -> Everyone can acces it (any class, any code)
                                                    // Protected -> Only this class and subclasses can acces it
                                                    // Private -> Only class itself can acces it
        {
            return 0.045; // We don't do the calculations here bcs Balance is set on private, to calculations on Account.ApplyInterest()
        }

    }
}