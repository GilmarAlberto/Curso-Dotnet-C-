/*
Faça um programa que leia 5 números e informe o maior número
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int num, maior = int.MinValue;

        Random rand = new Random();

        for(int i = 1; i <= 5; i++){

            num = rand.Next(0,101);

            Console.Write($"{num} ");

            if(num > maior){
                maior = num;
            }
        }

        Console.WriteLine($"\nO maior número é {maior}.");
    }

}