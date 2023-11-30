/*
14. João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que leia a variável peso (peso de peixes) e calcule o excesso. Gravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor da multa que João deverá pagar. Imprima os dados do programa com as mensagens adequadas.

*/

class Program
{
    
    static void Main(string[] args)
    {
        float peso, excesso, multa;

        do
        {
            System.Console.WriteLine("Digite o peso total pescado: ");
        } while ((!double.TryParse(Console.ReadLine(), out peso)));

        excesso = peso - 50.00;
        multa = excesso * 4.00;

        System.Console.WriteLine($"O total pescado foi {peso}");
        System.Console.WriteLine($"O excesso pescado foi {excesso}");
        System.Console.WriteLine($"A multa foi R$ {multa}");
     
    }

}

