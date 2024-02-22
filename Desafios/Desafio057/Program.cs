/*
Faça um programa que peça dois números, base e expoente, calcule e
mostre o primeiro número elevado ao segundo número. Não utilize a
função de potência da linguagem.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int bases    = rand.Next(1,11);
        int expoente = rand.Next(1,11);
        int total    = 1;

        for(int i = 1; i <= expoente; i++){
            total *= bases;
        }

        Console.WriteLine($"{bases} ** {expoente} = {total}");  
    }
}