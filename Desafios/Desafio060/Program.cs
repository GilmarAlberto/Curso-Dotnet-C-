/*
A série de Fibonacci é formada pela seqüência
0,1,1,2,3,5,8,13,21,34,55,... Faça um programa que gere a série até
que o valor seja maior que 500.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("0 1 ");
        int ant = 0, atu = 1;

        while (ant + atu < 500){
            int prox = ant + atu;
                
            Console.Write(prox + " ");

            ant  = atu;
            atu  = prox;
                
        }

    }

}