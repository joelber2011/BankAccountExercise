using BankAccountExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise.Utils
{
    public static class AccountValidation
    {
        private static readonly int MaxAttemps = 3;

        public static Account ValidateAccountType(int num)
        {

            for (int i = 0; i < MaxAttemps; i++)
            {
                switch (num)
                {
                    case 1:

                        return new Account();

                    case 2:

                        return new BusinessAccount();

                    default:

                        Console.WriteLine("OPÇÃO INVÁLIDA.");
                        Console.WriteLine($"TENTATIVAS RESTANTES: {MaxAttemps - i}");
                        Console.WriteLine("POR FAVOR, INSIRA UMA OPÇÃO VÁLIDA:");
                        num = Convert.ToInt16(Console.ReadLine());

                        break;

                }
            }
            Console.WriteLine("NÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
            Environment.Exit(0);
            return null; // Necessário para evitar erro de compilação, mas não será alcançado

        }

        public static void ValidateOperation(int selection, Account account)
        {
            for (int i = 0; i < MaxAttemps; i++)
            {
                switch (selection)
                {
                    case 1:
                        Console.Write("DIGITE O VALOR DO SAQUE: ");
                        double withDrawAmount = Convert.ToDouble(Console.ReadLine());
                        account.WithDraw(withDrawAmount);
                        return;

                    case 2:
                        Console.Write("DIGITE O VALOR DO DEPÓSITO: R$ ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        return;

                    case 3:
                        if (account is BusinessAccount businessAccount)
                        {
                            Console.Write("DIGITE O VALOR DO EMPRÉSTIMO: R$ ");
                            double loanAmount = Convert.ToDouble(Console.ReadLine());
                            businessAccount.Loan(loanAmount);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("OPERAÇÃO DE EMPRÉSTIMO INDISPONÍVEL PARA SUA CONTA.");
                            return;
                        }                        

                    default:

                        Console.WriteLine("OPÇÃO INVÁLIDA.");
                        Console.WriteLine($"TENTATIVAS RESTANTES: {MaxAttemps - i}");
                        Console.WriteLine("POR FAVOR, INSIRA UMA OPÇÃO VÁLIDA:");
                        selection = Convert.ToInt16(Console.ReadLine());

                        break;
    
                }

            }

            Console.WriteLine("NÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
            Environment.Exit(0);
        }

    }

}

