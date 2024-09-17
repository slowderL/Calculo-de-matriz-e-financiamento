using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FinanciamentoVeiculoTests
{
    [TestMethod]
    public void TestarCalculoParcela()
    {
        // Arrange: Definir os valores de teste
        double valorCarro = 50000; // Valor do carro
        double entrada = 10000; // Valor da entrada
        double taxaJuros = 0.02; // 2% de juros mensais
        int quantidadeParcelas = 24; // Parcelas em 24 meses

        // Valor esperado (calculado previamente)
        double parcelaEsperada = 2114.85;

        // Act: Executar o método que calcula a parcela
        double parcelaCalculada = FinanciamentoVeiculo.CalcularParcela(valorCarro, entrada, taxaJuros, quantidadeParcelas);

        // Assert: Verificar se a parcela calculada está correta
        Assert.AreEqual(parcelaEsperada, parcelaCalculada, 0.01, "O valor da parcela não está correto.");
    }
}