using BankAccountExercise.Entities;
using BankAccountExercise.Utils;

namespace BankAccountExercise
{
    static class Program
    {
        static void Main()
        {

            Console.WriteLine("Qual conta quer acessar?\nConta pessoal: 1\nConta corporativa: 2");
            int tpConta = Convert.ToInt32(Console.ReadLine());

            Account selectedAccount;
            switch (tpConta)
            {
                case 1:
                    selectedAccount = AccountValidation.CreatePersonalAccount();
                    break;

                case 2:
                    selectedAccount = AccountValidation.CreateBusinessAccount();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.WriteLine($"Seguem seus dados:\n____________________\n{selectedAccount}");

            Console.WriteLine("\nSelecione a operação:\n____________________\nSaque: Digite 1\nDepósito: Digite 2\nEmpréstimo: Digite 3\n____________________");
            int tpOperation = Convert.ToInt32(Console.ReadLine());

            AccountValidation.ValidateOperation(tpOperation, selectedAccount);


        }
    }
}