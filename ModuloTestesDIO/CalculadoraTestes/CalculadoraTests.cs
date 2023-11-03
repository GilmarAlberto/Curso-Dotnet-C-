using Calculadora.Services;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp(); 
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1,num2);

        //Assert
        Assert.Equal(15,resultado);
    }

    [Fact]
    public void DeveVericarSe4EhParERetornaVerdadeiro()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(new int[] {2,4})]
    [InlineData(new int4[] {6,8,10})]
    //[InlineData(6)]
    //[InlineData(8)]
    //[InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoPares(int[] numeros)
    {
        
        //Act/Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}