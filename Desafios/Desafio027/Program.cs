/*
27. Faça um Programa que leia três números e mostre-os em ordem decrescente.
*/

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, num3, menor, medio, maior;

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

        menor = medio = maior = num1;

        if(num2 > maior){
            medio = maior;
            maior = num2;
        }else if (num2 < menor){
            medio = menor;
            menor = num2;
        }else{
            medio = num2;
        }

        if(num3 > maior){
            medio = maior;
            maior = num3;
        }else if(num3 < menor){
            medio = menor;
            menor = num3;
        }else{
            medio = num3;
        }

        if(num2 < menor){
            medio = menor;
            menor = num2;
        }

        System.Console.WriteLine($"A sequência em ordem decrescente é {maior} - {medio} - {menor}");
    }

}