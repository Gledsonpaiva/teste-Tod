using Xunit;

public class CalculadoraTests
{
    [Fact]
    public void TestarAdicao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        double resultado = calculadora.Adicionar(5, 3);

        // Assert
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestarSubtracao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        double resultado = calculadora.Subtrair(5, 3);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestarMultiplicacao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        double resultado = calculadora.Multiplicar(5, 3);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void TestarDivisao()
    {
        // Arrange
        Calculadora calculadora = new Calculadora();

        // Act
        double resultado = calculadora.Dividir(6, 3);

        // Assert
        Assert.Equal(2, resultado);
    }
}