/*
Altere o programa de cálculo do fatorial, permitindo ao usuário calcular
o fatorial várias vezes e limitando o fatorial a números inteiros positivos
e menores que 16.
*/

class Program
{
    static void Main(string[] args)
    {
        int num = 0;

        do{
            int fat = 1;
            
            do
            {
                Console.WriteLine("Digite um número entre 0 e 16 para calcular o fatorial:");
            } while (!int.TryParse(Console.ReadLine(), out num) || (num < -1 || num > 16));

            if (num == -1){
                break;
            }

            Console.WriteLine(num);

            for(int i = 2; i <= num; i++){
                    fat *= i;
            }
            
            Console.WriteLine($"O fatorial {num}! é {fat}");    
        }while(num != -1);
    }
}