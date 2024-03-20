using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }

        public BusinessAccount()
        {
            
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                Console.WriteLine($"Empréstimo realizado com sucesso!\nSaldo atual: R$ {Balance}");
            }
            else
            {
                Console.WriteLine($"Operação cancelada. Empréstimo excedeu o limite.\nSaldo atual: R$ {Balance}");
            }
        }

        public override string ToString()
        {
            return "Número da conta: " + Number +
                "Titular: " + Holder +
                "Saldo da conta: R$ " + Balance +
                "Limite da conta: R$ " + LoanLimit;
        }
    }
}
