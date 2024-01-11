/*
37.Faça um Programa que leia um número inteiro menor que 1000 e imprima a quantidade de centenas, dezenas e unidades do mesmo.
— Observando os termos no plural a colocação do "e", da vírgula
entre outros. Exemplo:
- 326=3 centenas, 2 dezenas e 6 unidades
- 12=1 dezena e 2 unidades Testar com: 326, 300, 100, 320,
310,305, 301, 101, 311,111,25,20,10,21,11,1,7e16

*/

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[] {326, 12, 326, 300, 100, 320, 310, 305, 301, 101, 311, 111, 25, 20, 10, 21, 11, 1, 7, 16, 986, 837, 702, 601, 598, 487, 276};
        int unidade = 0, dezena = 0, centena = 0, i;

        for(i = 0; i < vetor.Length; i++){
        
            centena = vetor[i] / 100;
            dezena  = (vetor[i] % 100) / 10;
            unidade = (vetor[i] % 100) % 10;

            if(centena != 0){
                System.Console.Write($"{centena} centena");

                if(centena > 1){
                    System.Console.Write("s");
                }

                if(dezena != 0 && unidade != 0){
                    System.Console.Write(", ");
                }else if(dezena != 0 || unidade != 0 ){
                    System.Console.Write(" e ");
                }
            }
          
            if(dezena != 0){
                System.Console.Write($"{dezena} dezena");

                if(dezena > 1){
                    System.Console.Write("s");
                }

                if(unidade != 0){
                    System.Console.Write(" e ");
                }
            }

            if(unidade != 0){
                System.Console.Write($"{unidade} unidade");
            }

            if(unidade > 1){
                System.Console.Write("s");
            }

            System.Console.WriteLine();
            
        }

        
        
    }

}