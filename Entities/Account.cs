using System.Globalization;

namespace BankAccountExercise.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; } = null!;
        public double Balance { get; protected set; } = 0!;

        //Construtor padrão
        public Account() { }

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
                Console.WriteLine($"SALDO INSUFICIENTE PARA SAQUE!");
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"DEPÓSITO REALIZADO COM SUCESSO!");
        }

        public override string ToString()
        {
            return "NÚMERO DA CONTA: " + Number + "\n" +
                "TITULAR: " + Holder + "\n" +
                "SALDO DA CONTA: R$ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
