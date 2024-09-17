using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            // Exibe o menu de opções
            Console.WriteLine("\nSelecione uma das opções abaixo:");
            Console.WriteLine("1 - Cálculo de Financiamento de Veículo");
            Console.WriteLine("2 - Operações com Matriz Quadrada");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            // Lê a opção escolhida pelo usuário
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    FinanciamentoVeiculo.Executar();
                    break;
                case "2":
                    OperacoesMatriz.Executar();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}