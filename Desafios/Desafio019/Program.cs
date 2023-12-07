/*
19. Faça um Programa que peça dois numeros e imprima o maior deles. 

*/

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        do
        {
            System.Console.WriteLine("Digite o primeiro número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num1)));

        do
        {
            System.Console.WriteLine("Digite o segundo número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num2)));

        System.Console.WriteLine($"O maior número é {((num1 >= num2) ? num1 : num2)}");
     
    }

}

