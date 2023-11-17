/*
10. Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit.
*/

class Program
{
    static void Main(string[] args)
    {
        double fahr, celsius;

        do
        {
            System.Console.WriteLine("Digite uma temperatura em Celsius: ");
        }while (!double.TryParse(Console.ReadLine(), out celsius));

        fahr = (9.0 / 5.0) * celsius + 32;

        Console.WriteLine($"A temperatura em Fahrenheit é: {fahr}");
    }
}
