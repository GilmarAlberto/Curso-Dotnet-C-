/*
Faça um programa que peça 10 números inteiros, calcule e mostre a
quantidade de números pares e a quantidade de números impares
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int par = 0, impar = 0, num;

        for(int i = 1; i <= 10; i++){
            num = rand.Next(0,101);
            Console.Write($"{num} ");

            if(num % 2 == 0){
                par++;
            }else{
                impar++;
            }
        }

        Console.WriteLine($"\nPares: {par}");
        Console.WriteLine($"Impares: {impar}");
    }

}