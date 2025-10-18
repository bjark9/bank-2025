namespace BankApplication
{
    class CurrentAccount : BankApplication_Cours.Account
    {
        public double CreditLine { get; set; }
        protected override double CalculInterest()
        {
            if (Balance > 0)
            {
                return 0.03; // 3%
            }
            else
            {
                return 0.0975; // 9.75%
            }

        }
    }
}