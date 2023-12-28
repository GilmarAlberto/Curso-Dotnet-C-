/*
32.Faça um programa que lê as duas notas parciais obtidas por um aluno
numa disciplina ao longo de um semestre, e calcule a sua média. A atribuição de conceitos obedece à tabela abaixo:
o Média de Aproveitamento Conceito Entre 9.0 e 10.0 A
Entre 7.5 e 9.0 B
Entre 6.0 é 7.5 c
Entre 4.0 e 6.0 D
Entre 4.0 e zero E
O algoritmo deve mostrar na tela as notas, a média, o conceito correspondente e a mensagem “APROVADO” se o conceito for A, B ou C ou “REPROVADO” se o conceito for D ou E.

*/

class Program
{
    static void Main(string[] args)
    {
        decimal nota1, nota2, media;
        char    conceito;
        string  msg;

        do
        {
            System.Console.WriteLine("Digite a nota 1: ");
        } while ((!decimal.TryParse(Console.ReadLine(), out nota1)));  

        do
        {
            System.Console.WriteLine("Digite a nota 2: ");
        } while ((!decimal.TryParse(Console.ReadLine(), out nota2))); 

        media = (nota1 + nota2) / 2;

        if(media >= 9m){
            conceito = 'A';
        }else if(media >= 7.5m){
            conceito = 'B';
        }else if(media >= 6m){
            conceito = 'C';
        }else if(media >= 4m){
            conceito = 'D';
        }else{
            conceito = 'E';
        }

        if("ABC".Contains(conceito)){
            msg = "APROVADO";
        }else{
            msg = "REPROVADO";
        }

        System.Console.WriteLine($"A média é {media}");
        System.Console.WriteLine($"O conceito é {conceito}");
        System.Console.WriteLine($"A situação é {msg}");

    }

}