/*
16. Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

*/

class Program
{
    static void Main(string[] args)
    {
        double m2, qtdLatas, precoTotal, qtdLitros;

        do
        {
            System.Console.WriteLine("Digite a área a ser pintada: ");
        } while ((!double.TryParse(Console.ReadLine(), out m2)));

        qtdLitros = m2/3;
        qtdLatas = Math.Ceiling(qtdLitros/18);
        precoTotal = qtdLatas * 80.00;

        System.Console.WriteLine($"Quantidade de latas de tintas: {qtdLatas}");
        System.Console.WriteLine($"Preço Total: {precoTotal}");
     
    }

}

