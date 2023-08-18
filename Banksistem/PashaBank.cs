namespace Banksistem
{
        public class PashaBank : Bank
        {
            public PashaBank(string name, string surname, string code, int cvv, decimal balance) : base(name, surname, code, cvv, balance)
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
                Balance = Balance + amount - ((amount * 0.6m) / 100);
                Console.WriteLine("PashaBank balance is: " + Balance);
            }
            public override void WithDraw(decimal amount)
            {
            if(amount < Balance)
            {
                Balance = Balance - amount - ((amount * 1.1m) / 100);
                Console.WriteLine("PashaBank balance is: " + Balance);
            }
            else Console.WriteLine("Balance is not enough");
        }

        }

    }
