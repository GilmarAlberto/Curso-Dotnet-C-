/*
Altere o programa anterior para mostrar no final a soma dos números.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int num1 = rand.Next(0,101);
        int num2 = rand.Next(0,101);
        int soma = 0;

        Console.WriteLine($"num1: {num1}, num2: {num2}");

        if(num1 < num2){
            for (int i = num1; i <= num2; i++){
                Console.Write($"{i} ");
                soma+=i;
            }
        }else{
            for (int i = num2; i <= num1; i++){
                Console.Write($"{i} ");
                soma+=i;
            }
        }

        Console.WriteLine($"\nSoma: {soma}.");   
    }
}