/*
Faça um programa que imprima na tela apenas os números ímpares
entre 1 e 50.
*/

class Program
{
    static void Main(string[] args)
    {
        for(int i = 1; i < 50; i++){
            if(i % 2 != 0){
                Console.Write($"{i} ");
            }
        }     
    }
}