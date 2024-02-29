/*
A série de Fibonacci é formada pela seqüência
1,1,2,3,5,8,13,21,34,55,... Faça um programa capaz de gerar a série
até o n−ésimo termo
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de termos: ");    
        int num = int.Parse(Console.ReadLine() ?? "0");

        if(num == 0){
            Console.WriteLine("Não existe sequência de Fibonacci com ZERO membros!");
        }else if(num == 1){
            Console.WriteLine("0");
        }else{
            Console.Write("0 1 ");
            int ant = 0, atu = 1;

            for(int i = 3; i <= num; i++){
                int prox = ant + atu;
                
                Console.Write(prox + " ");

                ant  = atu;
                atu  = prox;
                
           }

        }

    }

}