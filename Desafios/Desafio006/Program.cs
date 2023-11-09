/*
6. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
*/

class Program
{
    static void Main(string[] args)
    {
        double raio, area;

        do
        {
            System.Console.WriteLine("Digite o raio de um círculo: ");
        }while (!double.TryParse(Console.ReadLine(), out raio));

        area = Math.PI * Math.Pow(raio,2);

        System.Console.WriteLine($"A área do círculo é {area}");
    }
}
