/*
39. um Programa que peça um número inteiro e determine se ele é
par ou impar. Dica: utilize o operador módulo (resto da divisão).
*/

class Program
{
    static void Main(string[] args)
    {
        int valor;

        do
        {
            System.Console.WriteLine("Digite um número: ");
        } while ((!int.TryParse(Console.ReadLine(), out valor)));

        if(valor % 2 == 0){
            System.Console.WriteLine("O número é par!");
        }else{
            System.Console.WriteLine("O número é impar!");
        }

    }

}