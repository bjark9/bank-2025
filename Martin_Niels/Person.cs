namespace BankApplication_Cours
{
    public class Person
    {
        public Person(string FirstName, string LastName, DateTime BirthDate) {}
        public  string FirstName { get; private set; }
        public string LastName { get; private set; }
        public  DateTime BirthDate { get; private set; }
    }
}