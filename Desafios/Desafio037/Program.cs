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
        //string texto;

        for(i = 0; i < vetor.Length; i++){
        
            centena = vetor[i] / 100;
            dezena  = (vetor[i] % 100) / 10;
            unidade = (vetor[i] % 100) % 10;

            System.Console.WriteLine($"numero: {vetor[i]} ");
            System.Console.WriteLine($"{centena} centenas, {dezena} dezenas, {unidade} unidades");


        }
        
    }

}