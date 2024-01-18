/*
40.Faça um Programa que peça um número e informe se o número é inteiro ou decimal. Dica: utilize uma função de arredondamento.

*/

class Program
{
    static void Main(string[] args)
    {
        float num;

        do
        {
            System.Console.WriteLine("Digite um número: ");
        } while ((!float.TryParse(Console.ReadLine(), out num)));

        if(num == (int)num){
            System.Console.WriteLine("O número é inteiro!");
        }else{
            System.Console.WriteLine("O número é decimal!");
        }

    }

}