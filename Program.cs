using BankAccountExercise.Entities;
using BankAccountExercise.Utils;

namespace BankAccountExercise
{
    static class Program
    {
        static void Main()
        {
            int tentativas = 3;
            int opcao;

            Account? selectedAccount = null;

            do
            {                
                if (selectedAccount == null)
                {
                    int tpConta;
                    int contaNum;

                    Console.WriteLine("QUAL CONTA QUER ACESSAR?\nCONTA PESSOAL: 1\nCONTA CORPORATIVA: 2");
                    while (!int.TryParse(Console.ReadLine(), out tpConta) || (tpConta != 1 && tpConta != 2))
                    {
                        tentativas--;
                        Console.WriteLine("\nOPÇÃO INVÁLIDA.");
                        if (tentativas == 0)
                        {
                            Console.WriteLine("\nNÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
                            return;
                        }
                        Console.WriteLine($"TENTATIVAS RESTANTES: {tentativas}");
                        Console.WriteLine("POR FAVOR, INSIRA UMA OPÇÃO VÁLIDA:");
                    }

                    Console.Write("\nINFORME O NÚMERO DA CONTA: ");
                    while(!int.TryParse(Console.ReadLine(), out contaNum))
                    {
                        tentativas--;
                        Console.Write("ERRO - A CONTA DEVE CONTER APENAS NÚMEROS.\nDIGITE NOVAMENTE: ");
                        if(tentativas == 0)
                        {
                            Console.WriteLine("\nNÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
                            return;
                        }
                    }

                    Console.Write("INFORME O NOME DO TITULAR: ");
                    string? titular = Console.ReadLine();

                    switch (tpConta)
                    {
                        case 1:
                            selectedAccount = new Account(contaNum, titular!, 0.0);
                            break;

                        case 2:
                            selectedAccount = new BusinessAccount(contaNum, titular!, 0.0, 1000.00);
                            break;

                        default:

                            Console.WriteLine("OPÇÃO INVÁLIDA.");
                            return;
                    }

                    Console.WriteLine($"\nSEGUEM SEUS DADOS:\n---------------------\n{selectedAccount}");
                }




                int tpOperation;
                Console.WriteLine("\nSELECIONE A OPERAÇÃO:\n---------------------\nSAQUE: DIGITE 1\nDEPÓSITO: DIGITE 2\nEMPRÉSTIMO: DIGITE 3\n---------------------");
                while (!int.TryParse(Console.ReadLine(), out tpOperation) || tpOperation < 1 || tpOperation > 3)
                {
                    tentativas--;
                    Console.WriteLine("OPÇÃO INVÁLIDA. POR FAVOR, SELECIONE UMA OPÇÃO VÁLIDA:");
                    if (tentativas == 0)
                    {
                        Console.WriteLine("NÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
                        return;
                    }
                }

                AccountValidation.ValidateOperation(tpOperation, selectedAccount);
                Console.WriteLine($"\nDADOS ATUALIZADOS:\n---------------------\n{selectedAccount}\n");

                Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?\nSIM: DIGITE 1\nNÃO: DIGITE 2");
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao != 1 && opcao != 2))
                {
                    tentativas--;
                    Console.WriteLine("OPÇÃO INVÁLIDA. POR FAVOR, SELECIONE UMA OPÇÃO VÁLIDA:");
                    if (tentativas == 0)
                    {
                        Console.WriteLine("NÚMERO MÁXIMO DE TENTATIVAS ALCANÇADO. ENCERRANDO...");
                        return;
                    }
                }
                Console.WriteLine($"\nDADOS ATUALIZADOS:\n---------------------\n{selectedAccount}\n");

            } while (opcao == 1);

            Console.WriteLine("OPERAÇÃO FINALIZADA!");


        }
    }
}