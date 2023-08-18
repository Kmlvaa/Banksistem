namespace Banksistem
{
    public class LeoBank : Bank
    {
        public LeoBank(string name, string surname, string code, int cvv, decimal balance) : base(name, surname, code, cvv, balance)
        {
            {
                Name = name;
                Surname = surname;
                Code = code;
                CVV = cvv;
                Balance = balance;
            }
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("LeoBank balance is: " + Balance);
        }
        public override void WithDraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine("LeoBank balance is: " + Balance);
        }
    }
}