/*
Faça um programa que leia 5 números e informe o maior número
*/

class Program
{
    static void Main(string[] args)
    {
        int num, maior = int.MinValue;

        for(int i = 1; i <= 5; i++){

            Console.WriteLine("Digite o número " + i);

            num = int.Parse(Console.ReadLine());

            if(num > maior){
                maior = num;
            }
        }

        Console.WriteLine($"O maior numero é {maior}.");
    }

}