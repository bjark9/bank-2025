class Bank
{
    public required string NameBank; // Public properties start with capital letter
    private List<long> usedAccountNumbers = new List<long>(); // Use List because don't need to know size when instantiating it.
    private List<long> usedIBANNumbers = new List<long>(); // Use List because don't need to know size when instantiating it.
    private List<Account> accounts = new List<Account>();
    private Random random = new Random();   // Need to be here bc ensure there’s only one random generator used by the entire Bank class instance. 
                                            // C# seeds random instance on time (in milliseconds), so if you create multiple Random objects
                                            // In quick succession, all those instances might get the same seed.
    public Account CreateAccount(string name, string firstName, int balance = 1000)
    {
        // Random accountNumber
        bool checkOver = false;
        long numAccount = 0;
        do // Check if numAccount is in usedAccountNumbers
        {
            numAccount = random.NextInt64(1000000000000000, 9999999999999999); // Random account number
            checkOver = (usedAccountNumbers.Contains(numAccount)) ? true : false; // If contains numAccount -> checkOver = false (keep loop)
        } while (checkOver); // 

        usedAccountNumbers.Add(numAccount); // Add new account to list of used account numbers

        // Random IBAN number
        checkOver = false;
        long numIBAN = 0;
        do
        {
            numIBAN = random.NextInt64(10000000000000, 99999999999999); // 14 number 
            checkOver = (usedIBANNumbers.Contains(numIBAN)) ? true : false; // If contains numIBAN -> checkOver = true
        } while (checkOver);

        string IBAN = numIBAN.ToString();
        IBAN = "BE" + IBAN;

        // Add all data to the account  
        Account account = new Account { AccountNumber = numAccount, IBAN = IBAN, Balance = balance, Name = name, FirstName = firstName };
        accounts.Add(account);
        return account;
    }
}