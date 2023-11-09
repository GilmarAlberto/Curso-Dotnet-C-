/*
8. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.
*/

class Program
{
    static void Main(string[] args)
    {
        double porHora, horas, salario;

        do
        {
            System.Console.WriteLine("Quanto você ganha por hora? ");
        }while (!double.TryParse(Console.ReadLine(), out porHora));

        do
        {
            System.Console.WriteLine("Quantas foram as horas trabalhadas?");
        }while (!double.TryParse(Console.ReadLine(), out horas));

        salario = porHora * horas;

        System.Console.WriteLine($"Total do salário no mês: R$ {salario:F2}");

    }

}