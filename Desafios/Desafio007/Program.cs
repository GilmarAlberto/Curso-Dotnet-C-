/*
7. Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
*/

class Program
{
    static void Main(string[] args)
    {
        int lado, area;

        do
        {
            System.Console.WriteLine("Digite o lado de um quadrado: ");
        }while (!int.TryParse(Console.ReadLine(), out lado));

        area = lado * lado;

        System.Console.WriteLine($"A área do quadrado é {area} e o seu dobro é {area*2}");
    }
}