/*
9. Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a temperatura em graus Celsius.
C = 5 * ((F-32) / 9).
*/

class Program
{
    static void Main(string[] args)
    {
        double fahr, celsius;

        do
        {
            System.Console.WriteLine("Digite uma temperatura em Fahrenheit: ");
        }while (!double.TryParse(Console.ReadLine(), out fahr));

        celsius = 5 * ((fahr - 32) / 9);

        System.Console.WriteLine($"A temperatura convertida para Celsius é {celsius:F2}º");

    }
    
}
