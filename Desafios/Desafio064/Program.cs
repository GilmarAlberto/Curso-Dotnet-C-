/*
Altere o programa anterior para que ele aceite apenas números entre 0
e 1000.
*/

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int num = rand.Next(0,1001);
        int menor = int.MaxValue, maior = int.MinValue, soma = 0;

        for(int i = 0; i < num; i++){
            int j = rand.Next(0,1001);

            Console.Write($"{j} ");
            if(j < menor){
                menor = j;
            }
            
            if(j > maior){
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