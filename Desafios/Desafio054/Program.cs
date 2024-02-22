/*
Faça um programa que receba dois números inteiros e gere os
números inteiros que estão no intervalo compreendido por eles
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int num1 = rand.Next(0,101);
        int num2 = rand.Next(0,101);

        Console.WriteLine($"num1: {num1}, num2: {num2}");

        if(num1 < num2){
            for (int i = num1; i <= num2; i++){
                Console.Write($"{i} ");
            }
        }else{
            for (int i = num2; i <= num1; i++){
                Console.Write($"{i} ");
            }
        }    
    }
}