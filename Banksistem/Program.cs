namespace Banksistem
{
    public abstract partial class Bank
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Code { get; set; }
        protected int CVV { get; set; }
        protected decimal Balance { get; set; }
        public Bank(string name, string surname, string code, int cvv, decimal balance)
        {
            Name = name;
            Surname = surname;
            Code = code;
            CVV = cvv;
            Balance = balance;
        }

        public abstract void Deposit(decimal amount);
        public abstract void WithDraw(decimal amount);

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var unibank = new UniBank("Samira", "Kamilova", "1111000011110000", 012, 20);
            Console.WriteLine(unibank.ToString());
            unibank.WithDraw(21);
            unibank.Deposit(50);
            var access = new AccessBank("Samira", "Kamilova", "1111000011110000", 012, 100m);
            access.Deposit(50);
            access.WithDraw(25);
            var pashabank = new PashaBank("Samira", "Kamilova", "1111000011110000", 012, 200);
            pashabank.Deposit(50);
            pashabank.WithDraw(25);
            var leobank = new LeoBank("Samira", "Kamilova", "1111000011110000", 012, 250m);
            leobank.Deposit(50);
            leobank.WithDraw(25);

        }
    }
}