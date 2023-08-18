namespace Banksistem
{
    public class UniBank : Bank
    {
        public UniBank(string name, string surname, string code, int cvv, decimal balance) : base(name, surname, code, cvv, balance)
        {
            {
                Name = name;
                Surname = surname;
                Code = code;
                CVV = cvv;
                Balance = balance;
            }
        }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("UniBank balance is: " + Balance);
        }
        public override void WithDraw(decimal amount)
        {
            if(Balance > amount)
            {
            Balance = Balance - amount - ((amount * 1.5m) / 100);
            Console.WriteLine("Unibank balance is: " + Balance);
            }
           
        }

    }
}