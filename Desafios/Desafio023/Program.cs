/*
23. Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a média alcançada por aluno e apresentar:
- A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
- A mensagem "Reprovado", se amédia for menor do que sete;
- A mensagem "Aprovado com Distinção", se a média for igual a dez.
*/

class Program
{
    static void Main(string[] args)
    {
        double nota1, nota2, media;

        do
        {
            System.Console.WriteLine("Digite a nota 1: ");
        } while ((!double.TryParse(Console.ReadLine(), out nota1)));

        do
        {
            System.Console.WriteLine("Digite a nota 2: ");
        } while ((!double.TryParse(Console.ReadLine(), out nota2)));

        media = (nota1 + nota2) / 2;

        if(media >= 10)
        {
            System.Console.WriteLine("Aprovado com distinção!");
        }
        else if(media >= 7)
        {
            System.Console.WriteLine("Aprovado!");
        }
        else
        {
            System.Console.WriteLine("Reprovado!");
        }

    }

}