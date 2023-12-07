/*
20. Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo. 
*/

class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;

        do
        {
            System.Console.WriteLine("Digite um número: ");
        } while ((!int.TryParse(Console.ReadLine(), out num1)));

        System.Console.WriteLine($"O número digitado é {(num1>=0 ? "positivo" : "negativo")}");
     
    }

}

