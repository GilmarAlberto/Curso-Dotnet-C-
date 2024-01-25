/*
Faça um programa que peça uma nota, entre zero e dez. Mostre uma
mensagem caso o valor seja inválido e continue pedindo até que o
usuário informe um valor válido.
*/

class Program
{
    static void Main(string[] args)
    {
        double nota;
        

        do
        {
            Console.WriteLine("Digite uma nota entre 0 e 10");
            
            if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
            {
                break;
            }
    
            Console.WriteLine("Nota Inválida!");

        } while (true);
    }

}