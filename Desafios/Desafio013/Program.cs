/*
13. Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
a. Para homens: (72.7*h) - 58
b. Para mulheres: (62.1*h) - 44.7

*/

class Program
{
    static void Main(string[] args)
    {
        double altura, pesoH, pesoM;

        do
        {
            System.Console.WriteLine("Digite a altura: ");
        } while ((!double.TryParse(Console.ReadLine(), out altura)));

        pesoH = Math.Round((72.7 * altura) - 58,2);
        pesoM = Math.Round((62.1 * altura) - 44.7,2);

        System.Console.WriteLine($"O peso ideal para uma pessoa do sexo masculino com {altura} de altura é {pesoH}");

        System.Console.WriteLine($"O peso ideal para uma pessoa do sexo feminino com {altura} de altura é {pesoM}");

    }

}

