/*
Faça um programa que calcule o fatorial de um número inteiro
fornecido pelo usuário. Ex.: 5!=5.4.3.2.1=120
*/

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int num = rand.Next(0,11);
        int fat = 1;

        Console.WriteLine(num);

        for(int i = 2; i <= num; i++){
                fat *= i;
        }
        
        Console.WriteLine($"O fatorial {num}! é {fat}");    
    }

}