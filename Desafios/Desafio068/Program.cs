/*
Lista 17 - programa 23
Faça um programa que mostre todos os primos entre 1 e N sendo N
um número inteiro fornecido pelo usuário. O programa deverá mostrar
também o número de divisões que ele executou para encontrar os
números primos. Serão avaliados o funcionamento, o estilo e o número
de testes (divisões) executados.
*/

using System;


class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int  num   = rand.Next(2,1001);
        int totalDivisoes = 0;
        
        Console.WriteLine($"Número aleatório gerado: {num}");
        Console.WriteLine($"Números primos entre 1 e {num}:");

        for(int i = 2; i <= num; i++){

            bool primo = true;
            int qtdDivisoes = 0;

            for(int j = 2; j <= Math.Sqrt(i); j++){

                qtdDivisoes++;

                if(i % j == 0){

                    primo = false;
                    break;

                }
                
            }

            totalDivisoes += qtdDivisoes;

            if(primo){
                Console.WriteLine(i);
            }
            
        } 
        Console.WriteLine($"Foram feitas {totalDivisoes} divisões.");
    }

}