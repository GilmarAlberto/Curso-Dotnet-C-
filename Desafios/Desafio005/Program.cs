/*
5. Faça um Programa que converta metros para centímetros.
*/

class Program
{
    static void Main(string[] args)
    {
        int metros, centimetros;

        do
        {
            System.Console.WriteLine("Digite um valor em metros: ");
        }while (!int.TryParse(Console.ReadLine(), out metros));

        centimetros = metros * 100;

        System.Console.WriteLine($"{metros} metros equivalem a {centimetros} centímetros");
     
    }

}
