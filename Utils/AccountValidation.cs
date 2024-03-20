using BankAccountExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise.Utils
{
    public class AccountValidation : Account
    {

        public static Account CreatePersonalAccount()
        {
            return new Account(2011, "Joelber", 0.0);
        }

        public static BusinessAccount CreateBusinessAccount()
        {
            return new BusinessAccount(2547, "Minha empresa", 0.0, 1000.00);
        }

        public static void ValidationTpConta(int num)
        {
            int tentativas = 3;

            switch (num)
            {
                case 1:
                    Entities.Account account = new(2011, "Joelber", 0.0);
                    Console.WriteLine($"Seguem seus dados: \n{account}");
                    break;

                case 2:
                    Entities.BusinessAccount businessAccount = new(2547, "Minha empresa", 0.0, 1000.0);
                    Console.WriteLine($"Seguem seus dados corporativos: \n{businessAccount}");
                    break;

                default:


                    for (int i = 1; i < tentativas; i++)
                    {
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine($"Tentativas restantes: {tentativas - i}");
                        Console.WriteLine("Por favor, insira uma opção válida:");
                        num = Convert.ToInt16(Console.ReadLine());

                        if (num == 1 || num == 2)
                        {
                            break;
                        }
                    }
                    if (num != 1 && num != 2)
                    {

                        Console.WriteLine("Número máximo de tentativas alcançado. Encerrando...");
                    }
                    break;

            }

        }

        public static void ValidateOperation(int selection, Account account)
        {
            int tentativas = 3;

            switch (selection)
            {
                case 1:
                    Console.Write("Digite o valor do saque: ");
                    double withDrawAmount = Convert.ToDouble(Console.ReadLine());
                    account.WithDraw(withDrawAmount);
                    break;

                case 2:
                    Console.Write("Digite o valor do depósito: R$ ");
                    double depositAmount = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;

                case 3:
                    if (account is BusinessAccount businessAccount)
                    {
                        Console.WriteLine("Digite o valor do empréstimo: R$ ");
                        double loanAmount = Convert.ToDouble(Console.ReadLine());
                        businessAccount.Loan(loanAmount);
                    }
                    else
                    {
                        Console.WriteLine("Operação de empréstimo indisponível para sua conta.");
                    }
                    break;

                default:


                    for (int i = 1; i < tentativas; i++)
                    {
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine($"Tentativas restantes: {tentativas - i}");
                        Console.WriteLine("Por favor, insira uma opção válida:");
                        selection = Convert.ToInt16(Console.ReadLine());

                        if (selection == 1 || selection == 2 || selection == 3)
                        {
                            break;
                        }
                    }
                    if (selection != 1 && selection != 2 && selection != 3)
                    {

                        Console.WriteLine("Número máximo de tentativas alcançado. Encerrando...");
                    }
                    break;

            }
        }
    }
}
