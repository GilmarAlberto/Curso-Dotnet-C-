/*
25. Faça um Programa que leia três números e mostre o maior e o menor deles.
*/

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, maior, menor;

        do
        {
            System.Console.WriteLine("Digite o primeiro número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num1)));

        do
        {
            System.Console.WriteLine("Digite o segundo número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num2)));

        do
        {
            System.Console.WriteLine("Digite o terceiro número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num3)));
     
        maior = num1;
        menor = num1;

        if(num2 > maior){
            maior = num2;
        }

        if(num3 > maior){
            maior = num3;
        }

        if(num2 < menor){
            menor = num2;
        }

        if(num3 < menor){
            menor = num3;
        }

        System.Console.WriteLine($"O menor número é {menor}");
        System.Console.WriteLine($"O maior número é {maior}");
    }

}