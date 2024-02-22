/*
Faça um programa que leia 5 números e informe a soma e a média
dos números.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int num, soma = 0;
        double media;

        Random rand = new Random();

        for(int i = 1; i <= 5; i++){
            num = rand.Next(0, 101);

            Console.Write($"{num} ");

            soma += num;
        }

        media = (double)soma / 5;

        Console.WriteLine($"\nA soma é {soma}.");
        Console.WriteLine($"A média é {media}.");

     
    }

}