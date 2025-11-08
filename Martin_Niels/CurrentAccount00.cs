namespace BankApplication_Cours
{
    class CurrentAccount : Account
    {
        public CurrentAccount(string AccNumber, object Owner):base(AccNumber,Owner) { }
        public CurrentAccount(string AccNumber, object Owner, double Balance):base(AccNumber,Owner,Balance) {}
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