/*
36.Faça um Programa que peça uma data no formato dd/mm/aaaa e determine se a mesma é uma data válida.

*/

class Program
{
    static void Main(string[] args)
    {
        int dia, mes, ano;

        do
        {
            System.Console.WriteLine("Digite dia: ");
        } while ((!int.TryParse(Console.ReadLine(), out dia)));

        do
        {
            System.Console.WriteLine("Digite mês: ");
        } while ((!int.TryParse(Console.ReadLine(), out mes)));

        do
        {
            System.Console.WriteLine("Digite ano: ");
        } while ((!int.TryParse(Console.ReadLine(), out ano)));

        if((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && (dia >= 1 && dia <= 31)){
            System.Console.WriteLine("Data Correta");
        }else if (mes == 2 && ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0) && (dia >= 1 && dia <= 29)){
            System.Console.WriteLine("Data Correta");
        }else if(mes == 2 && (dia >= 1 && dia <= 28)){
            System.Console.WriteLine("Data Correta");
        }else if((mes == 4 || mes == 6 || mes == 9 || mes == 11) && (dia >= 1 && dia <= 30)){
            System.Console.WriteLine("Data Correta");
        }else{
            System.Console.WriteLine("Data Incorreta");
        }
     
    }

}
