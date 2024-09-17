using System;

public class FinanciamentoVeiculo
{
    public static double CalcularParcela(double valorCarro, double entrada, double taxaJuros, int quantidadeParcelas)
    {
        double valorFinanciado = valorCarro - entrada;
        double parcela = valorFinanciado * (taxaJuros * Math.Pow(1 + taxaJuros, quantidadeParcelas)) /
                        (Math.Pow(1 + taxaJuros, quantidadeParcelas) - 1);
        return parcela;
    }

    public static void Executar()
    {
        Console.WriteLine("\nCálculo de Financiamento de Veículo");

        Console.Write("Informe o valor do carro: R$ ");
        double valorCarro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor da entrada: R$ ");
        double entrada = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a taxa de juros mensal (em %): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Informe a quantidade de parcelas: ");
        int quantidadeParcelas = Convert.ToInt32(Console.ReadLine());

        double parcela = CalcularParcela(valorCarro, entrada, taxaJuros, quantidadeParcelas);

        double valorFinanciado = valorCarro - entrada;

        Console.WriteLine($"\nValor financiado: R$ {valorFinanciado:F2}");
        Console.WriteLine($"Valor da parcela: R$ {parcela:F2} em {quantidadeParcelas} vezes");
    }
}
