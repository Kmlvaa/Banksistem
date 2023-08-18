namespace Banksistem
{
    public class AccessBank : Bank
    {
        public AccessBank(string name, string surname, string code, int cvv, decimal balance) : base(name, surname, code, cvv, balance)
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
            Balance = Balance + amount - ((amount * 0.3m) / 100);
            Console.WriteLine("AccessBank balance is: " + Balance);
        }
        public override void WithDraw(decimal amount)
        {
            Balance = Balance - amount - ((amount * 1.6m) / 100);
            Console.WriteLine("AccessBank balance is: " + Balance);
        }


    }
}