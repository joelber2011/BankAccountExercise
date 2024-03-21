using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }

        //Construtor padrão
        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            
            if (amount <= LoanLimit)
            {
                Balance += amount;
                Console.WriteLine($"EMPRÉSTIMO REALIZADO COM SUCESSO!");
                LoanLimit -= amount;
            }
            else
            {
                Console.WriteLine($"OPERAÇÃO CANCELADA. EMPRÉSTIMO EXCEDEU O LIMITE.\nSALDO ATUAL: R$ {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public override string ToString() => base.ToString() + "\n" +
                "LIMITE DE EMPRÉSTIMO: R$ " + LoanLimit.ToString("F2", CultureInfo.InvariantCulture);
    }
}
