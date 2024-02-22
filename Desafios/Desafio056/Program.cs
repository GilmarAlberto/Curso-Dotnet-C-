/*
Desenvolva um gerador de tabuada, capaz de gerar a tabuada de
qualquer número inteiro entre 1 a 10. O usuário deve informar de qual
numero ele deseja ver a tabuada. 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int num = rand.Next(1,11);

        Console.WriteLine($"Tabuada de {num}: ");

        for(int i = 1; i <= 10; i++){
            Console.WriteLine($"{num} X {i} = {num * i}");
        }
    }
}