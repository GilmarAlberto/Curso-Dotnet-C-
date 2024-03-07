/*
Escreva a função maior_primo que recebe um número inteiro maior ou igual a 2 como parâmetro e devolve o maior número primo menor ou igual ao número passado à função

*/

using System;
class Program
{
    static int maior_primo(int n){
        
        for(int i = n; i >= 2; i--){
            bool primo = true;
            for(int j = 2; j <= Math.Sqrt(i); j++){
                if(i % j == 0){
                    primo = false;
                    break;
                }

            }

            if(primo){
                return(i);
            }
        }

        return -1;
    }
    static void Main(string[] args)
    {
        Random rand = new Random();
        int num = rand.Next(2,101);

        Console.WriteLine(num);

        Console.WriteLine(maior_primo(num));
     
    }

}