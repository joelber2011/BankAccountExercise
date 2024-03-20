namespace BankAccountExercise.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } = null!;
        public double Balance { get; protected set; }

        public Account()
        {
            
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void WithDraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;                
            }
            else
            {
                Console.WriteLine($"Saldo atual R$: {Balance}, insuficiente para o saque.");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;            
        }

        public override string ToString()
        {
            return "Número da conta: " + Number + "\n" +
                "Titular: " + Holder + "\n" +
                "Saldo da conta: R$ " + Balance;
        }

    }
}
