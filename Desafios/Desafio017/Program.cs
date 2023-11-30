/*
17. Faça um Programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 6 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00 ou em galões de 3,6 litros, que custam R$ 25,00.
Informe ao usuário as quantidades de tinta a serem compradas e os respectivos preços em 3 situações:
comprar apenas latas de 18 litros;
comprar apenas galões de 3,6 litros;
misturar latas e galões, de forma que o desperdício de tinta seja menor. Acrescente 10% de folga e sempre arredonde os valores para cima, isto é, considere latas cheias.

*/

class Program
{
    static void Main(string[] args)
    {
        double m2, qtdLatas, precoTotal, qtdLitros, qtdGaloes, precoTotalLatas, precoTotalGaloes;

        do
        {
            System.Console.WriteLine("Digite a área a ser pintada: ");
        } while ((!double.TryParse(Console.ReadLine(), out m2)));

        qtdLitros = (m2/6)*1.10;
        qtdLatas = Math.Ceiling(qtdLitros/18);
        qtdGaloes = Math.Ceiling(qtdLitros/3.6);
        precoTotalLatas = qtdLatas * 80.00;
        precoTotalGaloes = qtdGaloes * 25.00;

        System.Console.WriteLine($"Quantidade de latas de tinta: {qtdLatas}");
        System.Console.WriteLine($"Preço Total - Latas: {precoTotalLatas}");

        System.Console.WriteLine($"Quantidade de galões de tinta: {qtdGaloes}");
        System.Console.WriteLine($"Preço Total - Galões: {precoTotalGaloes}");

        qtdLatas = Math.Floor(qtdLitros/18);
        qtdGaloes = Math.Ceiling((qtdLitros-(qtdLatas*18))/3.6);

        precoTotal = (qtdLatas*80) + (qtdGaloes*25);

        System.Console.WriteLine($"Quantidade de latas de tinta: {qtdLatas}");
        System.Console.WriteLine($"Quantidade de galões de tinta: {qtdGaloes}");
        System.Console.WriteLine($"Preço Total - {precoTotal}")

    }

}

