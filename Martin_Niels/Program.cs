// See https://aka.ms/new-console-template for more information
/*
Bank account01 = new Bank { NameBank = "ING" };
Console.WriteLine(account01); // This writes the Class of the instance. (in this case writes Bank)
Console.WriteLine(account01.CreateAccount("Pierre","Jean")); // This writes the Class of the instance (in this case Account)
Console.WriteLine(account01.CreateAccount("Martin", "Niels").AccountNumber); // Writes AccountNumber
*/

// UI
Console.WriteLine("What is the name of your bank?");
string bankName = Console.ReadLine();
Bank account00 = new Bank { NameBank = bankName };
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine("What is your first name?");
string userFirstName = Console.ReadLine();
var acc = account00.CreateAccount(userName, userFirstName);

bool running = true;
while (running)
{
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("What action do you want to do?\n1) Show account info\n2) Make a transaction\n3) Quitter");
    int action = Int32.Parse(Console.ReadLine());
    Console.WriteLine("----------------------------------------------------------------------------------------");
    switch (action)
    {
        case 1:
            // Show account info
            Console.WriteLine($"Name: {acc.Name}\nFirst name: {acc.FirstName}\nAccount number: {acc.AccountNumber}\nIBAN: {acc.IBAN}\nBalance: {acc.Balance}");
            break;
        case 2:
            // Transaction
            Console.WriteLine("Do you want to deposit or withdraw money?");
            string transact = Console.ReadLine();
            bool a = true;
            if (transact == "deposit")
            {
                a = true;
            }
            else
            {
                a = false;
            }
            Console.WriteLine("With what amount do you want to change your balance?");
            long amount = long.Parse(Console.ReadLine());
            acc.Transaction(amount,a);
            Console.WriteLine($"Balance after transaction: {acc.Balance}");
            break;
        case 3:
            running = false; // Leave terminal
            break;
        default:
            Console.WriteLine("Invalid choice :/");
            break;
    };
}