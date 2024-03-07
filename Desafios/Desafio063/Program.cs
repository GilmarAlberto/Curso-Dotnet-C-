/*
.Faça um programa que, dado um conjunto de N números, determine o
menor valor, o maior valor e a soma dos valores.
*/

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int num = rand.Next(1,101);
        int menor = int.MaxValue, maior = int.MinValue, soma = 0;

        for(int i = 1; i <= num; i++){
            int j = rand.Next(1,101);

            Console.Write($"{j} ");
            if(j < menor){
                menor = j;
            }else if(j > maior){
                maior = j;
            }

            soma += j;
        }

        Console.WriteLine($"\nQtdNum: {num}");
        Console.WriteLine($"Menor: {menor}");
        Console.WriteLine($"Maior: {maior}");
        Console.WriteLine($"Soma: {soma}");
     
    }

}