/*
11. Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
a. o produto do dobro do primeiro com metade do segundo .
b. a soma do triplo do primeiro com o terceiro.
c. o terceiro elevado ao cubo.

*/

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
        double num3 = 0.0;
        double a, b, c;

        do
        {
            System.Console.WriteLine("Digite o primeiro número inteiro: ");
        }while (!int.TryParse(Console.ReadLine(), out num1));
    
        do
        {
            System.Console.WriteLine("Digite o segundo número inteiro: ");
        }while (!int.TryParse(Console.ReadLine(), out num2));

        do
        {
            System.Console.WriteLine("Digite um número real: ");
        }while (!double.TryParse(Console.ReadLine(), out num3));

        //a. o produto do dobro do primeiro com metade do segundo .
        a = (num1 * 2.0) * (num2/2.0);

        //b. a soma do triplo do primeiro com o terceiro.
        b = (num1 * 3.0) + num3;

        //c. o terceiro elevado ao cubo.
        c = Math.Pow(num3,3);

        System.Console.WriteLine($"a. o produto do dobro do primeiro com metade do segundo: {a}");
        System.Console.WriteLine($"b. a soma do triplo do primeiro com o terceiro: {b}");
        System.Console.WriteLine($"c. o terceiro elevado ao cubo: {c}");

    }
}