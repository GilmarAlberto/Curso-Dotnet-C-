/*
35.Faça um Programa que peça um número correspondente a um determinado ano e em seguida informe se este ano é ou não bissexto.
1. Se o ano for divisível por 4, vá para a etapa 2. Caso contrário, vá para a etapa 5.
2. Se o ano for divisível por 100, vá para a etapa 3. Caso contrário, vá para a etapa 4.
3. Se o ano for divisível por 400, vá para a etapa 4. Caso contrário, vá para a etapa 5.
4. O ano é bissexto (tem 366 dias).
5. ano não é bissexto (tem 365 dias).

*/

class Program
{
    static void Main(string[] args)
    {

        int ano;

        do
        {
            System.Console.WriteLine("Digite ano: ");
        } while ((!int.TryParse(Console.ReadLine(), out ano)));

        if(ano%4 == 0 && ano%100 != 0 || ano%400 == 0){
            System.Console.WriteLine($"O ano {ano} é bissexto!");
        }else{
            System.Console.WriteLine($"O ano {ano} não é bissexto!");
        }
     
    }

}